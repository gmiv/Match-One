//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        static readonly GameBoardElementComponent gameBoardElementComponent = new GameBoardElementComponent();

        public bool isGameBoardElement {
            get { return HasComponent(CoreComponentIds.GameBoardElement); }
            set {
                if (value != isGameBoardElement) {
                    if (value) {
                        AddComponent(CoreComponentIds.GameBoardElement, gameBoardElementComponent);
                    } else {
                        RemoveComponent(CoreComponentIds.GameBoardElement);
                    }
                }
            }
        }

        public Entity IsGameBoardElement(bool value) {
            isGameBoardElement = value;
            return this;
        }
    }
}

    public partial class CoreMatcher {
        static IMatcher _matcherGameBoardElement;

        public static IMatcher GameBoardElement {
            get {
                if (_matcherGameBoardElement == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.GameBoardElement);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherGameBoardElement = matcher;
                }

                return _matcherGameBoardElement;
            }
        }
    }
