public interface UIFactoryFactory {
    public static UIFactory getUIFactoryForPlatform(SupportedPlatform supportedPlatform)
    {
        if(supportedPlatform == supportedPlatform.ANDROID)
            return new AndroidUIFactory();
        else if(supportedPlatform == supportedPlatform.IOS)
            return new IOSUIFactory();

        return null;
    }
}
