namespace TheOneStudio.HyperCasual.Scenes.Main
{
    using GameFoundation.Scripts.UIModule.ScreenFlow.BaseScreen.Presenter;
    using GameFoundation.Scripts.UIModule.ScreenFlow.Managers;
    using GameFoundation.Scripts.Utilities.LogService;
    using GameFoundation.Signals;
    using TheOneStudio.UITemplate.UITemplate.Configs.GameEvents;
    using TheOneStudio.UITemplate.UITemplate.Scenes.Main;

    [ScreenInfo("HomeSimpleScreenView")]
    public class HomeSimpleScreenPresenter : UITemplateHomeSimpleScreenPresenter
    {
        public HomeSimpleScreenPresenter(SignalBus signalBus, ILogService logger, IScreenManager screenManager, GameFeaturesSetting gameFeaturesSetting) : base(signalBus, logger, screenManager, gameFeaturesSetting)
        {
        }
    }
}