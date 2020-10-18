using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Functions;
using Assignment1.Models;
using Assignment1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment1.Controllers
{
    public class GeneticController : Controller
    {
        public IActionResult Index()
        {
            //initial values
            int[] array = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            GeneticVM GVM = new GeneticVM()
            {
                array = array,
                dimension = 4,
                heuristic = 0,
                dimensions = new List<SelectListItem>()
                {
                    new SelectListItem{Text="4x4",Value="4"},
                    new SelectListItem{Text="5x5",Value="5"},
                    new SelectListItem{Text="6x6",Value="6"},
                    new SelectListItem{Text="7x7",Value="7"},
                    new SelectListItem{Text="8x8",Value="8"},
                    new SelectListItem{Text="9x9",Value="9"},
                    new SelectListItem{Text="10x10",Value="10"},
                    new SelectListItem{Text="11x11",Value="11"},
                    new SelectListItem{Text="12x12",Value="12"},
                },

            };

            return View(GVM);
        }
        public IActionResult GenerateRandomState(int dim, int populationSize, int elitism, int crossoverProb, int mutationProb, int numberGenerations)
        {
            int[][] matrix = (Global.generateMatrix(dim));

            GeneticVM GVM = new GeneticVM()
            {
                array = Global.matrixToArray(matrix, dim),
                dimension = dim,
                heuristic = Global.Heuristic(matrix, dim),
                crossoverProb = crossoverProb,
                elitism = elitism,
                mutationProb = mutationProb,
                numberGenerations = numberGenerations,
                populationSize = populationSize,
                dimensions = new List<SelectListItem>()
                {
                    new SelectListItem{Text="4x4",Value="4"},
                    new SelectListItem{Text="5x5",Value="5"},
                    new SelectListItem{Text="6x6",Value="6"},
                    new SelectListItem{Text="7x7",Value="7"},
                    new SelectListItem{Text="8x8",Value="8"},
                    new SelectListItem{Text="9x9",Value="9"},
                    new SelectListItem{Text="10x10",Value="10"},
                    new SelectListItem{Text="11x11",Value="11"},
                    new SelectListItem{Text="12x12",Value="12"},
                }

            };

            return View("Index", GVM);
        }
        static int rouletteSelection(List<State> chromosomes, int k)
        {
            int i = -1;
            int sum = 0;
            for (int j = 0; j < k; j++)
            {
                sum += chromosomes[j].h;
            }
            int a = new Random().Next(0, sum);
            sum = 0;

            do
            {
                i++;
                sum += chromosomes[i].h;
            } while (sum < a);

            return i;
        }
        public void Crossover(State C1, State C2, int dim)
        {
            int x = new Random().Next(0, dim);
            int y = new Random().Next(0, dim);

            if (y < x)
            {
                int temp = y;
                y = x;
                x = temp;
            }
            for (int i = x; i < y + 1; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (C1.matrix[j][i] == 1 || C2.matrix[j][i] == 1)
                    {
                        int temp = C1.matrix[j][i];
                        C1.matrix[j][i] = C2.matrix[j][i];
                        C2.matrix[j][i] = temp;
                    }
                }
            }
            C1.h = Global.Heuristic(C1.matrix, dim);
            C2.h = Global.Heuristic(C2.matrix, dim);
        }
        public void Mutation(State Cm, int dim)
        {
            int col1 = new Random().Next(0, dim);
            int col2;
            do
            {
                col2 = new Random().Next(0, dim);
            } while (col2 == col1);

            int temp;
            for (int i = 0; i < dim; i++)
            {
                temp = Cm.matrix[i][col1];
                Cm.matrix[i][col1] = Cm.matrix[i][col2];
                Cm.matrix[i][col2] = temp;
            }
            Cm.h = Global.Heuristic(Cm.matrix, dim);
        }
        public IActionResult GeneticAlgorithm(string stringArray, int dim, int populationSize, int elitism, double crossoverProb, double mutationProb, int numberGenerations)
        {
            int[] array = Global.StringToInt(stringArray, dim);
            int[][] Matrix = Global.arrayToMatrix(array, dim);

            List<State> chromosomes = new List<State>();

            chromosomes.Add(new State(dim));    //adding initial state to chromosomes/random states
            chromosomes[0].matrix = Matrix;
            chromosomes[0].h = Global.Heuristic(Matrix, dim);
            for (int i = 1; i < populationSize; i++) //adding rest of random chromosomes/random states
            {
                chromosomes.Add(new State(dim));
                chromosomes[i].matrix = Global.generateMatrix(dim);
                chromosomes[i].h = Global.Heuristic(chromosomes[i].matrix, dim);
            }

            bool change;
            State bestChromosome;
            int counter = 0;
            while (numberGenerations > 0)//do until we go through all generations
            {
                change = true;
                while (change)    //sort chromosomes by h
                {
                    change = false;
                    for (int i = 0; i < populationSize-1 ; i++)
                    {
                            if (chromosomes[i].h > chromosomes[i + 1].h)
                            {
                                State s = chromosomes[i];
                                chromosomes[i] = chromosomes[i + 1];
                                chromosomes[i + 1] = s;
                                change = true;
                            }
                    }
                }
                bestChromosome = chromosomes[0];
                if (bestChromosome.h == 0) //if we find solution 
                    break;
                List<State> chromsToAdd = new List<State>();
                for (int i = 0; i < populationSize * elitism / 100; i++)
                {
                    chromsToAdd.Add(chromosomes[i]);    //adding elite chromosomes to the next generation
                }
                for (int i = chromsToAdd.Count() / 2; i < populationSize / 2; i++)//adding the rest of chromosomes to the next generation
                {
                    int k = rouletteSelection(chromosomes, populationSize);//roulette Selection- select a parent
                    State C1 = chromosomes[k];
                    int n;
                    do
                    {
                        n = rouletteSelection(chromosomes, populationSize);//select second parent
                    } while (n == k);//restriction not to have same chromosome as two parents
                    State C2 = chromosomes[n];
                    State C1c = C1;
                    State C2c = C2;
                    if (new Random().NextDouble() < crossoverProb)//if the propability is high enough we do the crossover between two parents
                    {
                        Crossover(C1c, C2c, dim);
                    }
                    State C1m = C1c;
                    State C2m = C2c;
                    if (new Random().NextDouble() < mutationProb)//if the propability is high enough we do the mutation of each of the parents
                    {
                        Mutation(C1m, dim);
                        Mutation(C2m, dim);
                    }
                    chromsToAdd.Add(C1m);
                    chromsToAdd.Add(C2m);
                }
                counter++;
                chromosomes = chromsToAdd;
                numberGenerations--;
            }

            if (chromosomes[0].h != 0)
            {
                change = true;
                while (change)    //because on the end of while loop we don't sort the final generation, so we do it here to 
                {
                    change = false;
                    for (int i = 0; i < populationSize - 1; i++)
                    {
                        if (chromosomes[i].h > chromosomes[i + 1].h)
                        {
                            State s = chromosomes[i];
                            chromosomes[i] = chromosomes[i + 1];
                            chromosomes[i + 1] = s;
                            change = true;
                        }
                    }
                }
            }
            GeneticVM GVM = new GeneticVM()
            {
                array = Global.matrixToArray(chromosomes[0].matrix, dim),
                dimension = dim,
                heuristic = chromosomes[0].h,
                crossoverProb = crossoverProb,
                elitism = elitism,
                mutationProb = mutationProb,
                numberGenerations = numberGenerations,
                populationSize = populationSize,
                dimensions = new List<SelectListItem>()
                {
                    new SelectListItem{Text="4x4",Value="4"},
                    new SelectListItem{Text="5x5",Value="5"},
                    new SelectListItem{Text="6x6",Value="6"},
                    new SelectListItem{Text="7x7",Value="7"},
                    new SelectListItem{Text="8x8",Value="8"},
                    new SelectListItem{Text="9x9",Value="9"},
                    new SelectListItem{Text="10x10",Value="10"},
                    new SelectListItem{Text="11x11",Value="11"},
                    new SelectListItem{Text="12x12",Value="12"},
                },
                counter = counter
            };
            return PartialView("GeneticDone", GVM);
        }
    }
}