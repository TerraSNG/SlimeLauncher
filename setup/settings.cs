namespace Terraria.SlimeLauncer.Properties {
       
    // Этот класс позволяет обрабатывать определенные события в классе настроек:
    // Событие SettingChanging вызывается до изменения значения настройки.
    // Событие PropertyChanged вызывается после изменения значения параметра.
    // Событие SettingsLoaded вызывается после загрузки значений настроек.
    // Событие SettingsSaving вызывается до сохранения значений настроек.
      
    internal sealed partial class Settings {
        
        public Settings() {
            
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Добавьте код для обработки SettingChangingEvent настроек.        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Добавьте код для обработки сохранения настроек.        }
    }
}
