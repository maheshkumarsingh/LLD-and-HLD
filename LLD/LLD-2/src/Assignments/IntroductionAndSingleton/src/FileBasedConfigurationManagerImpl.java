package com.assignment.question;

public class FileBasedConfigurationManagerImpl extends FileBasedConfigurationManager {
    private static FileBasedConfigurationManagerImpl manager;

    private FileBasedConfigurationManagerImpl() { }
    @Override
    public String getConfiguration(String key) {
        // TODO Auto-generated method stub
        return properties.getProperty(key);
    }

    @Override
    public <T> T getConfiguration(String key, Class<T> type) {
        // TODO Auto-generated method stub
        String value = properties.getProperty(key);
        if(value == null)
            return null;
        return convert(value, type);
    }

    @Override
    public void setConfiguration(String key, String value) {
        // TODO Auto-generated method stub
        properties.setProperty(key, value);
    }

    @Override
    public <T> void setConfiguration(String key, T value) {
        // TODO Auto-generated method stub
        properties.setProperty(key, value.toString());
    }

    @Override
    public void removeConfiguration(String key) {
        // TODO Auto-generated method stub
        properties.remove(key);
    }

    @Override
    public void clear() {
        // TODO Auto-generated method stub
        properties.clear();
    }

    public static FileBasedConfigurationManager getInstance() {
        if(manager == null)
        {
            manager = new FileBasedConfigurationManagerImpl();
        }
        return manager;
    }

    public static void resetInstance() {
        manager = null;
    }
}