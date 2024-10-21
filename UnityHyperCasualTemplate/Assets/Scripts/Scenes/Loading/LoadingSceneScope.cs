namespace TheOneStudio.HyperCasual.Scenes.Loading
{
    using GameFoundation.DI;
    using GameFoundation.Scripts.UIModule.Utilities;
    using VContainer;

    public class LoadingSceneScope : SceneScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.InitScreenManually<LoadingScenePresenter>();
        }
    }
}