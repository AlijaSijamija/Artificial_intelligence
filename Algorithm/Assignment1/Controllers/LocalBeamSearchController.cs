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
    public class LocalBeamSearchController : Controller
    {
        public IActionResult Index()
        {
            //initial values
            int[] a = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            LocalBeamSearchVM LBSVM = new LocalBeamSearchVM()
            {
                array = a,
                dimension = 4,
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
            return View(LBSVM);
        }
        public IActionResult GenerateRandomState(int dim, int states, int maxCounter)
        {
            int[][] array = Global.generateMatrix(dim);

            LocalBeamSearchVM LBSVM = new LocalBeamSearchVM()
            {
                array = Global.matrixToArray(array, dim),
                dimension = dim,
                heuristic = Global.Heuristic(array, dim),
                numberStates = states,
                maxCounter = maxCounter,
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

            return View("Index", LBSVM);
        }
        public IActionResult LocalBeamSearchAlgorithm(string stringArray, int dim, int states, int maxCounter)
        {
            int[] array = Global.StringToInt(stringArray, dim);
            int[][] matrix = Global.arrayToMatrix(array, dim);

            State[] BestStates = new State[states];
            for (int i = 0; i < states; i++)    //generating k random states
            {
                BestStates[i] = new State(dim);
                BestStates[i].matrix = Global.generateMatrix(dim);
                BestStates[i].h = Global.Heuristic(BestStates[i].matrix, dim);
            }
            bool change = true;
            while (change)  //sort initial states
            {
                change = false;
                for (int i = 0; i < states - 1; i++)
                {
                    if (BestStates[i].h > BestStates[i + 1].h)
                    {
                        State s = BestStates[i];
                        BestStates[i] = BestStates[i + 1];
                        BestStates[i + 1] = s;
                        change = true;
                    }
                }
            }
            State[] allStates = new State[states * states];
            int counter2 = 0;
            while (BestStates[0].h != 0 && counter2 < maxCounter) 
            {
                int counter = 0;

                for (int i = 0; i < states; i++)
                {
                    for (int j = 0; j < states; j++)
                    {
                        allStates[counter] = new State(dim);
                        allStates[counter].matrix = Global.randomSuccessor(Global.CopyMatrix(BestStates[j].matrix, dim), dim); //for k states we are making k random single moves
                        allStates[counter].h = Global.Heuristic(allStates[counter].matrix, dim);
                        counter++;
                    }
                }

                change = true;  //sort expanded array
                while (change)
                {
                    change = false;
                    for (int i = 0; i < states * states - 1; i++)
                    {
                        if (allStates[i].h > allStates[i + 1].h)
                        {
                            State s = allStates[i];
                            allStates[i] = allStates[i + 1];
                            allStates[i + 1] = s;
                            change = true;
                        }
                    }
                }
                for (int i = 0; i < states; i++)    //selecting k best states
                {
                    BestStates[i].matrix = Global.CopyMatrix(allStates[i].matrix, dim);
                    BestStates[i].h = Global.Heuristic(allStates[i].matrix, dim);
                }
                counter2++;
            }
            LocalBeamSearchVM LBSVM = new LocalBeamSearchVM()
            {
                array = Global.matrixToArray(BestStates[0].matrix, dim),
                dimension = dim,
                heuristic = Global.Heuristic(BestStates[0].matrix, dim),
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
                counter = counter2,
                numberStates = states,
                maxCounter = maxCounter

            };
            return PartialView("LBSDone", LBSVM);
        }
    }
}