namespace ME.ECS.Collections {

    public static class IntrusiveCoreComponentsInitializer {

        static IntrusiveCoreComponentsInitializer() {
            
             CoreComponentsInitializer.RegisterInitCallback(() => {
                 
                 WorldUtilities.InitComponentTypeId<ME.ECS.Collections.IntrusiveData>(false, isBlittable: true);
                 WorldUtilities.InitComponentTypeId<ME.ECS.Collections.IntrusiveSortedListData>(false, isBlittable: true);
                 WorldUtilities.InitComponentTypeId<ME.ECS.Collections.IntrusiveListNode>(false, isBlittable: true);
                 WorldUtilities.InitComponentTypeId<ME.ECS.Collections.IntrusiveHashSetBucket>(false, isBlittable: true);
                 WorldUtilities.InitComponentTypeId<ME.ECS.Collections.IntrusiveHashSetData>(false, isBlittable: true);
                 
             }, (State state, ref World.NoState noState) => {
                 
                 state.structComponents.ValidateUnmanaged<ME.ECS.Collections.IntrusiveData>(ref state.allocator, false);
                 state.structComponents.ValidateUnmanaged<ME.ECS.Collections.IntrusiveSortedListData>(ref state.allocator, false);
                 state.structComponents.ValidateUnmanaged<ME.ECS.Collections.IntrusiveListNode>(ref state.allocator, false);
                 state.structComponents.ValidateUnmanaged<ME.ECS.Collections.IntrusiveHashSetBucket>(ref state.allocator, false);
                 state.structComponents.ValidateUnmanaged<ME.ECS.Collections.IntrusiveHashSetData>(ref state.allocator, false);
                 
             }, (in Entity entity) => {
                 
                 entity.ValidateDataUnmanaged<ME.ECS.Collections.IntrusiveData>(false);
                 entity.ValidateDataUnmanaged<ME.ECS.Collections.IntrusiveSortedListData>(false);
                 entity.ValidateDataUnmanaged<ME.ECS.Collections.IntrusiveListNode>(false);
                 entity.ValidateDataUnmanaged<ME.ECS.Collections.IntrusiveHashSetBucket>(false);
                 entity.ValidateDataUnmanaged<ME.ECS.Collections.IntrusiveHashSetData>(false);
                 
             });
            
        }

    }

}