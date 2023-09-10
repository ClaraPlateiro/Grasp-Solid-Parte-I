using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class CostoTotal
    {
        public double GetProductionCost(ArrayList steps)
        {
            double costoInsumos = 0;
            double costoEquipamiento = 0;

            foreach (Step step in steps)
            {
                costoInsumos += (step.Quantity/1000) * step.Input.UnitCost; //Paso de gramos a Kilos
            }

            foreach (Step step in steps)
            {
                costoEquipamiento += (step.Time/60) * step.Equipment.HourlyCost; //Paso de segundos a minutos
            }

            double CostoTotal = costoInsumos + costoEquipamiento;
            return CostoTotal;
        }

    }
}

//Utilicé el principio SOLID (Principio de Responsabilidad Única) para asignar la responsabilidad de calcular el costo total de producir un producto final.