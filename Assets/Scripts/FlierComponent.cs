using Unity.Entities;

// Components are purely data structures, ideally
// shouldn't have any behaviours
public struct FlierComponent : IComponentData {
    public float speed;
}
