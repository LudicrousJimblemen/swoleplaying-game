using Unity.Entities;
using Unity.Transforms;

// this is where behaviours should be implemented
// i think the idea is that a system controls all entities that have a specific collection of components
// e.g. all behaviours that concern both a FlierComponent and a Translation happen here?
// or maybe a system is only meant to have one behaviour at once
public class FlySystem : ComponentSystem {
    protected override void OnUpdate() {
        // runs on all entities that have these components
        Entities.ForEach((ref FlierComponent rotator, ref Translation translation) => {
            translation.Value.x += rotator.speed * Time.DeltaTime;
        });
    }
}
