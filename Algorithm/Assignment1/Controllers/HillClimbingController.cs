using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assignment1.Functions;

namespace Assignment1.Controllers
{
    public class HillClimbingController : Controller
    {
        public IActionResult Index()
        {
            //Initial values
            int[] a = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            HillClimbingVM InitialVM = new HillClimbingVM()
            {
                array = a,
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

            return View(InitialVM);
        }
        public IActionResult GenerateRandomState(int dim, int stepsInSameState)
        {
            int[][] matrix = Global.generateMatrix(dim); 

            HillClimbingVM HCVM = new HillClimbingVM()
            {
                array = Global.matrixToArray(matrix, dim),
                dimension = dim,
                heuristic = Global.Heuristic(matrix, dim),  
                stepsInSameState = stepsInSameState,
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

            return View("Index", HCVM);
        }
        public int[][] GetBestHeuristic(int[][] matrix, int dim, int startHeuristic)
        {
            int heuristic = startHeuristic;
            int heuristic2;
            int[][] matrix2 = Global.CopyMatrix(matrix, dim);
            int[][] matrixFinal = Global.CopyMatrix(matrix, dim);
            if (startHeuristic > 0)
            {
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (matrix[i][j] != 1)
                        {
                            matrix2[i][j] = 1;
                            for (int k = 0; k < dim; k++)
                            {
                                if (matrix2[k][j] == 1 && i != k)
                                {
                                    matrix2[k][j] = 0;
                                    break;
                                }

                            }

                            heuristic2 = Global.Heuristic(matrix2, dim);
                            if (heuristic2 < heuristic)
                            {
                                heuristic = heuristic2;
                                matrixFinal = Global.CopyMatrix(matrix2, dim);
                            }
                            matrix2 = Global.CopyMatrix(matrix, dim);
                        }
                    }
                }
            }
            return matrixFinal;
        }
        public IActionResult HillClimbingAlgorithm(string stringArray, int dim, int stepsInSameState)
        {
            int[] array = Global.StringToInt(stringArray, dim);
            int[][] Matrix = new int[dim][];

            Matrix = Global.arrayToMatrix(array, dim);
            int heuristic = Global.Heuristic(Matrix, dim);
            int heuristic2 = 100;
            int[][] matrix2;
            int counter = 0;
            int counter2 = 0;
            while (heuristic != 0 && stepsInSameState > counter)
            {
                matrix2 = GetBestHeuristic(Matrix, dim, heuristic); 
                heuristic2 = Global.Heuristic(matrix2, dim);
                if (heuristic2 >= heuristic)
                {
                    counter++; 
                }
                if (heuristic2 <= heuristic)
                {
                    heuristic = heuristic2;
                    Matrix = Global.CopyMatrix(matrix2, dim);
                    heuristic2 = 100;
                }
                counter2++;
            }
            HillClimbingVM HCVM = new HillClimbingVM()
            {
                array = Global.matrixToArray(Matrix, dim),
                dimension = dim,
                heuristic = Global.Heuristic(Matrix, dim),
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
                stepsInSameState = stepsInSameState
            };
            return PartialView("HCDone", HCVM);
        }
    }
}