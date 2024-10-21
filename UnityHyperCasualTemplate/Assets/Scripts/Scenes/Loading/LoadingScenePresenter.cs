namespace TheOneStudio.HyperCasual.Scenes.Loading
{
    using BlueprintFlow.BlueprintControlFlow;
    using Core.AnalyticServices;
    using GameFoundation.Scripts.AssetLibrary;
    using GameFoundation.Scripts.UIModule.ScreenFlow.BaseScreen.Presenter;
    using GameFoundation.Scripts.Utilities.LogService;
    using GameFoundation.Scripts.Utilities.ObjectPool;
    using GameFoundation.Signals;
    using TheOneStudio.UITemplate.UITemplate.Scenes.Loading;
    using TheOneStudio.UITemplate.UITemplate.Scripts.ThirdPartyServices;
    using TheOneStudio.UITemplate.UITemplate.UserData;

    [ScreenInfo("LoadingScreenView")]
    public class LoadingScenePresenter : UITemplateLoadingScreenPresenter
    {
        protected LoadingScenePresenter(SignalBus signalBus, ILogService logger, UITemplateAdServiceWrapper adService, BlueprintReaderManager blueprintManager, UserDataManager userDataManager, IGameAssets gameAssets, ObjectPoolManager objectPoolManager, UITemplateAdServiceWrapper uiTemplateAdServiceWrapper, IAnalyticServices analyticServices) : base(signalBus, logger, adService, blueprintManager, userDataManager, gameAssets, objectPoolManager, uiTemplateAdServiceWrapper, analyticServices)
        {
        }
    }
}