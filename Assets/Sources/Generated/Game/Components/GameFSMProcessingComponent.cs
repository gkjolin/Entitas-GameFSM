//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly FSMProcessingComponent fSMProcessingComponent = new FSMProcessingComponent();

    public bool isFSMProcessing {
        get { return HasComponent(GameComponentsLookup.FSMProcessing); }
        set {
            if (value != isFSMProcessing) {
                var index = GameComponentsLookup.FSMProcessing;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : fSMProcessingComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherFSMProcessing;

    public static Entitas.IMatcher<GameEntity> FSMProcessing {
        get {
            if (_matcherFSMProcessing == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FSMProcessing);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFSMProcessing = matcher;
            }

            return _matcherFSMProcessing;
        }
    }
}