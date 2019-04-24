namespace Administración.DsProviSinPlanTableAdapters
{
    public partial class ProviSinPlanTableAdapter
    {
        public void SetTimeOut()
        {
            foreach (var command in CommandCollection)
            {
                command.CommandTimeout = 0;
            }
        }
    }
}

namespace Administración
{
    partial class DsProviSinPlan
    {
    }
}