using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Functions;
using Assignment1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment1.Controllers
{
    public class SimulatedAnealingController : Controller
    {
        public IActionResult Index()
        {
            int[] array = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SimulatedAnealingVM SAVM = new SimulatedAnealingVM()
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
            return View(SAVM);
        }
        public IActionResult GenerateRandomState(int dim, int T0, int coolingFactor)
        {
            int[][] matrix = Global.generateMatrix(dim);
            SimulatedAnealingVM SAVM = new SimulatedAnealingVM()
            {
                array = Global.matrixToArray(matrix, dim),
                dimension = dim,
                heuristic = Global.Heuristic(matrix, dim),
                T0 = T0,
                coolingFactor = coolingFactor,
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

            return View("Index", SAVM);
        }
        public IActionResult SimulatedAnealingAlgorithm(string stringArray, int dim, int T0, int coolingFactor)
        {
            int[] array = Global.StringToInt(stringArray, dim);
            int[][] matrix = Global.arrayToMatrix(array, dim);

            int[][] matrix2;
            int deltaH;
            int Hs = 1;
            int counter = 0;
            while (T0 > 0 && Hs != 0) 
            {
                matrix2 = Global.randomSuccessor(matrix, dim);
                Hs = Global.Heuristic(matrix2, dim);
                deltaH = Hs - Global.Heuristic(matrix, dim);

                if (deltaH < 0) 
                {
                    matrix = Global.CopyMatrix(matrix2, dim);
                }
                else if (Math.Pow(2.71828, -(deltaH / T0)) > new Random().NextDouble())
                //if the state is worse than previous state, we calculate propability for selecting it anyway  
 
                {
                    matrix = Global.CopyMatrix(matrix2, dim);
                }
                T0 -= coolingFactor;    
                counter++;
            }
            SimulatedAnealingVM SAVM = new SimulatedAnealingVM()
            {
                array = Global.matrixToArray(matrix, dim),
                dimension = dim,
                heuristic = Global.Heuristic(matrix, dim),
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
                counter = counter,
                T0 = T0,
                coolingFactor = coolingFactor
            };
            return PartialView("SADone", SAVM);
        }
    }
}