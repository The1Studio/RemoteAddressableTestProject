namespace TheOneStudio.HyperCasual.Scenes.Main
{
    using System.Linq;
    using GameFoundation.DI;
    using GameFoundation.Scripts.UIModule.Utilities;
    using GameFoundation.Scripts.Utilities.Extension;
    using TheOneStudio.HyperCasual.StateMachines.Game;
    using TheOneStudio.HyperCasual.StateMachines.Game.Interfaces;
    using TheOneStudio.UITemplate.Quests;
    using VContainer;

    public class MainSceneScope : SceneScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterQuestManager();

            builder.Register<GameStateMachine>(Lifetime.Singleton)
                .WithParameter(container => typeof(IGameState).GetDerivedTypes().Select(type => (IGameState)container.Instantiate(type)).ToList())
                .AsInterfacesAndSelf();

            builder.InitScreenManually<HomeSimpleScreenPresenter>();
        }
    }
}