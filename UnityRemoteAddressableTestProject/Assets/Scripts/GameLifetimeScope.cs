namespace TheOneStudio.HyperCasual
{
    using GameFoundation.DI;
    using GameFoundation.Scripts;
    using TheOneStudio.HyperCasual.Others;
    using TheOneStudio.UITemplate;
    using TheOneStudio.UITemplate.UITemplate.Services.Toast;
    using UnityEngine.EventSystems;
    using VContainer;
    using VContainer.Unity;

    public class GameLifetimeScope : LifetimeScope
    {
        public ToastController ToastController;

        protected override void Configure(IContainerBuilder builder)
        {
            //GDK stuff
            builder.RegisterGameFoundation(this.transform);
            builder.RegisterUITemplate(this.transform, this.ToastController);

            //Global UI event system
            builder.RegisterComponentInNewPrefabResource<EventSystem>(nameof(EventSystem), Lifetime.Singleton).UnderTransform(this.transform);
            builder.AutoResolve<EventSystem>(); // NonLazy

            builder.Register<GameRemoteConfig>(Lifetime.Singleton).AsInterfacesAndSelf();
        }
    }
}