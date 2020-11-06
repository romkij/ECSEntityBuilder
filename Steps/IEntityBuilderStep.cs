using Plugins.Shared.ECSEntityBuilder.Variables;
using Unity.Entities;

namespace Plugins.Shared.ECSEntityBuilder.Steps
{
    public interface IEntityBuilderStep
    {
        void Process(EntityManagerWrapper wrapper, EntityVariableMap variables, Entity entity);
    }
}