namespace Full_GRASP_And_SOLID.Library
{
    public class CostoTotal
    {
        public double GetProductionCost(Recipe recipe)
        {
            double costoInsumos = 0;

            double costoEquipamiento = 0;

            foreach (Step step in recipe.Steps)
            {
                costoInsumos += (step.Quantity/1000) * step.Input.UnitCost;
            }
             foreach (Step step in recipe.Steps)
            {
                costoEquipamiento += (step.Time/360) * step.Equipment.HourlyCost;
            }
            
            double costoTotal = costoInsumos + costoEquipamiento;
            return costoTotal;

        }
    }
}