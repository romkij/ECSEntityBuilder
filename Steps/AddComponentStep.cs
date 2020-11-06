using Plugins.Shared.ECSEntityBuilder.Variables;
using Unity.Entities;

namespace Plugins.Shared.ECSEntityBuilder.Steps
{
    public class AddComponentStep<T> : IEntityBuilderGenericStep<T> where T : struct, IComponentData
    {
        public void Process(EntityManagerWrapper wrapper, EntityVariableMap variables, Entity entity)
        {
            wrapper.AddComponent<T>(entity);
        }
    }
}