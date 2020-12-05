using Skclusive.Core.Component;

namespace Skclusive.Material.Container
{
    public class ContainerStyleProvider : StyleTypeProvider
    {
        public ContainerStyleProvider() : base(priority: 20, typeof(ContainerStyle))
        {
        }
    }
}