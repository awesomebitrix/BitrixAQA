using BitrixAQA.Selenium.Framework;
using OpenQA.Selenium;

namespace BitrixAQA.Selenium.Object_Repository
{
    /// <summary>
    /// Класс объектов главного модуля
    /// </summary>
    class TO_Main
    {
        /// <summary>
        /// Кнопка Окно JS ошибок в ИЕ Закрыть
        /// </summary>
        public static WebItem Button_IEJSErrorWindow_Close
        { 
            get
            {
                return new WebItem(By.XPath("//div[@class='footer']//button[text()='Закрыть']"), "Кнопка Окно JS ошибок в ИЕ Закрыть");
            }
        }

        /// <summary>
        /// Кнопка Окно JS ошибок в ИЕ Копировать сведения
        /// </summary>
        public static WebItem Button_IEJSErrorWindow_CopyError
        {
            get
            {
                return new WebItem(By.XPath("//button[contains(text(), 'копировать сведения')]"), "Кнопка Окно JS ошибок в ИЕ Копировать сведения");
            }
        }
        
        /// <summary>
        /// Таб Система обновлений
        /// </summary>
        public static WebItem Tab_UpdateSystem
        {
            get
            {
                return new WebItem(By.XPath("//span[@id='tab_cont_edit5']"), "Таб Система обновлений");
            }
        }

        /// <summary>
        /// Таб Система обновлений Старый
        /// </summary>
        public static WebItem Tab_UpdateSystem_OLD
        {
            get
            {
                return new WebItem(By.XPath("//td[@id='tab_cont_edit5']"), "Таб Система обновлений (Старый)");
            }
        }

        /// <summary>
        /// Выпадающий список Режим вывода ошибок
        /// </summary>
        public static WebItem DropDown_ErrorReporting
        {
            get
            {
                return new WebItem(By.XPath("//select[@name='error_reporting']"), "Выпадающий список Режим вывода ошибок");
            }
        }

        /// <summary>
        /// Текстбокс Ключ сервиса Яндекс.Перевод
        /// </summary>
        public static WebItem TextBox_YandexTranslateKey
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='translate_key_yandex']"), "Текстбокс Ключ сервиса Яндекс.Перевод");
            }
        }

        /// <summary>
        /// Кнопка Применить
        /// </summary>
        public static WebItem Button_Apply
        {
            get
            {
                return new WebItem(By.XPath("//input[@value='Применить']"), "Кнопка Применить");
            }
        }

        /// <summary>
        /// Текстбокс Лицензионный ключ
        /// </summary>
        public static WebItem TextBox_LicenseKey
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='SET_LICENSE_KEY']"), "Текстбокс Лицензионный ключ");
            }
        }

        /// <summary>
        /// Текстбокс Сервер обновлений
        /// </summary>
        public static WebItem TextBox_UpdateSite
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='update_site']"), "Текстбокс Сервер обновлений");
            }
        }

        /// <summary>
        /// Выпадающий список Автоматически проверять обновления
        /// </summary>
        public static WebItem DropDown_UpdateAutocheck
        {
            get
            {
                return new WebItem(By.XPath("//select[@name='update_autocheck']"), "Выпадающий список Автоматически проверять обновления");
            }
        }

        /// <summary>
        /// Мета тег страницы или раздела
        /// </summary>
        /// <param name="tagName">имя тега, пример robots</param>
        public static WebItem MetaTag(string tagName)
        {
            return new WebItem(By.XPath("//meta[@name='" + tagName + "']"), "Мета тег " + tagName);
        }

        /// <summary>
        /// Наименование страницы в админке
        /// </summary>
        public static WebItem Region_Title
        {
            get
            {
                return new WebItem(By.XPath("//h1[@id='adm-title']"), "Наименование страницы в админке");
            }
        }

        /// <summary>
        /// Кнопка Сохранить
        /// </summary>
        public static WebItem Button_Save
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='save' and @class='adm-btn-save']"), "Кнопка Сохранить");
            }
        }

        /// <summary>
        /// Кнопка Сохранить
        /// </summary>
        public static WebItem Button_Update
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='Update' and @class='adm-btn-save']"), "Кнопка Сохранить");
            }
        }

        /// <summary>
        /// Область сообщения в админке
        /// </summary>
        public static WebItem Region_InfoMsg
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='adm-info-message']"), "Область сообщения в админке");
            }
        }

        /// <summary>
        /// меню таб в админке
        /// </summary>
        /// <param name="tab_menu">наименование таб меню</param>
        public static WebItem Button_TabMenu(string tab_menu)
        {
            return new WebItem(By.XPath("//div[contains(@id,'tabs')]//span[contains(text(), '" + tab_menu + "')]"), "меню таб " + tab_menu);
        }

        /// <summary>
        /// меню таб во внешнем контейнере
        /// </summary>
        /// <param name="tab_menu">наименование таб меню</param>
        public static WebItem Button_TabMenu_Container(string tab_menu)
        {
            return new WebItem(By.XPath("//div[@class='bx-core-adm-dialog-tabs']//span[contains(text(), '" + tab_menu + "')]"),
                "меню таб " + tab_menu + " во внешнем контейнере");
        }

        /// <summary>
        /// Кнопка удалить
        /// </summary>
        public static WebItem Button_Delete
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='action_delete_button']"), "Кнопка удалить");
            }
        }

        /// <summary>
        /// кнопка из меню действия
        /// </summary>
        /// <param name="action">наименование кнопки</param>
        public static WebItem Button_ActionMenu(string action)
        {
            return new WebItem(By.XPath("//div[@id='bx-admin-prefix' and contains(@style, 'display: block;')]//span[contains(text(), '" + action + "')]"), "кнопка из меню действия " + action);
        }

        /// <summary>
        /// кнопка удалить модуль в списке модулей
        /// </summary>
        /// <param name="module">наименование модуля</param>
        public static WebItem Button_UninstallModule(string module)
        {
            return new WebItem(By.XPath("//b[contains(text(), '" + module + "')]//..//..//input[@name='uninstall']"), "кнопка удалить модуль " + module);
        }

        /// <summary>
        /// кнопка установить модуль в списке модулей
        /// </summary>
        /// <param name="module">наименование модуля</param>
        public static WebItem Button_InstallModule(string module)
        {
            return new WebItem(By.XPath("//b[contains(text(), '" + module + "')]//..//..//input[@name='install']"), "кнопка установить модуль " + module);
        }

        /// <summary>
        /// Чекбокс Скопировать публичные файлы и шаблон для сайта
        /// </summary>
        public static WebItem CheckBox_CopyPublic
        {
            get
            {
                return new WebItem(By.XPath("//label[@for='id_install_public']"), "Чекбокс Скопировать публичные файлы и шаблон для сайта");
            }
        }

        /// <summary>
        /// Чекбокс Переписывать существующие файлы
        /// </summary>
        public static WebItem CheckBox_PublicRewrite
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='id_public_rewrite']"), "Чекбокс Переписывать существующие файлы");
            }
        }

        /// <summary>
        /// Чекбокс все Юнит Тесты
        /// </summary>
        public static WebItem CheckBox_AllUnitTests
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='phpunit-tests-bxtest']"), "Чекбокс все Юнит Тесты");
            }
        }

        /// <summary>
        /// Чекбокс Юнит Теста
        /// </summary>
        /// <param name="TestName">Имя теста</param>
        public static WebItem CheckBox_UnitTests(string TestName)
        {
            return new WebItem(By.XPath("//input[@id='" + TestName + "']"), "Чекбокс Юнит Теста " + TestName);
        }

        /// <summary>
        /// Кнопка открытия Юнит Теста
        /// </summary>
        /// <param name="TestName">Имя теста</param>
        public static WebItem Button_OpenUnitTests(string TestName)
        {
            return new WebItem(By.XPath("//input[@id='" + TestName + "']//..//a"), "Кнопка открытия Юнит Теста " + TestName);
        }

        /// <summary>
        /// Кнопка Run
        /// </summary>
        public static WebItem Button_Run
        {
            get
            {
                return new WebItem(By.XPath("//input[@type='button' and @value='Run']"), "Кнопка Run");
            }
        }

        /// <summary>
        /// Кнопка удалить модуль
        /// </summary>
        public static WebItem Button_DeleteModule
        {
            get
            {
                return new WebItem(By.XPath("//input[@type='submit' and @value='Удалить модуль']"), "Кнопка удалить модуль ");
            }
        }

        /// <summary>
        /// Чекбокс Сохранить таблицы
        /// </summary>
        public static WebItem CheckBox_SaveTables
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='savedata']"), "Чекбокс сохранить таблицы");
            }
        }

        /// <summary>
        /// Чекбокс Сохранить таблицы включен
        /// </summary>
        public static WebItem CheckBox_SaveTablesON
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='savedata' and @checked='']"), "Чекбокс сохранить таблицы включен");
            }
        }

        /// <summary>
        /// Чекбокс Сохранить типы и шаблоны сообщений
        /// </summary>
        /// 
        public static WebItem CheckBox_SaveTemplates
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='saveemails']"), "Чекбокс Сохранить типы и шаблоны сообщений");
            }
        }

        /// <summary>
        /// Чекбокс Сохранить типы и шаблоны сообщений включен
        /// </summary>
        /// 
        public static WebItem CheckBox_SaveTemplatesON
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='saveemails' and @checked='']"), "Чекбокс Сохранить типы и шаблоны сообщений включен");
            }
        }

        /// <summary>
        /// Кнопка установить модуль общая
        /// </summary>
        public static WebItem Button_InstallModuleGeneral
        {
            get
            {
                return new WebItem(By.XPath("//input[@type='submit' and @value='Установить модуль']"), "Кнопка установить модуль общая ");
            }
        }

        /// <summary>
        /// Кнопка Вернуться к списку модулей
        /// </summary>
        public static WebItem Button_ReturnToList
        {
            get
            {
                return new WebItem(By.XPath("//input[@type='submit' and @value='Вернуться в список']"), "Кнопка Вернуться к списку модулей");
            }
        }

        /// <summary>
        /// Выпадающий список условий фильтрации
        /// </summary>
        public static WebItem Dropdown_Filter
        {
            get
            {
                return new WebItem(By.XPath("//select[@class ='adm-select' and @name='find_type']"), "Выпадающий список условий фильтрации");
            }
        }

        /// <summary>
        /// поле найти
        /// </summary>
        public static WebItem Textbox_FilterValue
        {
            get
            {
                return new WebItem(By.XPath("//input[@class ='adm-input' and @title='Введите строку для поиска']"), "поле найти");
            }
        }

        /// <summary>
        /// кнопка Найти
        /// </summary>
        public static WebItem Button_Find
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='set_filter']"), "кнопка Найти");
            }
        }

        /// <summary>
        /// кнопка Найти
        /// </summary>
        public static WebItem Button_FindGood
        {
            get
            {
                return new WebItem(By.XPath("//input[@class='adm-s-search-submit']"), "кнопка Найти");
            }
        }

        /// <summary>
        /// Кнопка установить новые обновления
        /// </summary>
        public static WebItem Button_NewUpdates
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='install_updates_button' and not(@disabled='')]"), "Кнопка установить новые обновления");
            }
        }

        /// <summary>
        /// Кнопка установить обновления
        /// </summary>
        public static WebItem Button_NewUpdates_Detail
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='install_updates_sel_button' and not(@disabled='')]"), "Кнопка установить обновления");
            }
        }

        /// <summary>
        /// Чекбокс все модули
        /// </summary>
        public static WebItem CheckBox_InstallAllModules
        {
            get
            {
                return new WebItem(By.XPath("//label[@class='adm-designed-checkbox-label' and @for='id_select_all']"), "Чекбокс все модули");
            }
        }

        /// <summary>
        /// Чекбокс установить модуль
        /// </summary>
        /// <param name="Module">Модуль</param>
        public static WebItem CheckBox_InstallModule(string Module)
        {
            return new WebItem(By.XPath("//label[@class='adm-designed-checkbox-label' and @for='" + Module + "']"), "Чекбокс установить модуль " + Module);
        }

        /// <summary>
        /// Чекбокс Модуль "1С-Битрикс: сайт 1С-Франчайзи"
        /// </summary>
        public static WebItem CheckBox_InstallFranchiseModule
        {
            get
            {
                return new WebItem(By.XPath("//label[@class='adm-designed-checkbox-label' and @for='id_select_module_franchise']"), "Чекбокс Модуль \"1С-Битрикс: сайт 1С-Франчайзи\"");
            }
        }

        /// <summary>
        /// Таб системы обновлений
        /// </summary>
        /// <param name="TabName">Имя закладки</param>
        public static WebItem Button_UpdateTab(string TabName)
        {
            return new WebItem(By.XPath("//div[@id='tabControl_tabs']//span[contains(text(), '" + TabName + "')]"), "Таб системы обновлений" + TabName);
        }

        /// <summary>
        /// Кнопка Открыть лицензионное соглашение
        /// </summary>
        public static WebItem Button_OpenLicense
        {
            get
            {
                return new WebItem(By.XPath("//input[@name = 'agree_licence_btn']"), "Кнопка Открыть лицензионное соглашение");
            }
        }

        /// <summary>
        /// Кнопка Обновить систему SiteUpdate
        /// </summary>
        public static WebItem Button_NewUpdateSystem
        {
            get
            {
                return new WebItem(By.XPath("//input[@name = 'updateupdate_btn']"), "Кнопка Обновить систему SiteUpdate");
            }
        }

        /// <summary>
        /// Кнопка применить
        /// </summary>
        public static WebItem Button_AcceptLicense
        {
            get
            {
                return new WebItem(By.XPath("//input[@id = 'licence_agree_button']"), "Кнопка применить");
            }
        }

        /// <summary>
        /// чекбокс Я принимаю лицензионное соглашение
        /// </summary>
        public static WebItem CheckBox_AgreeLicense
        {
            get
            {
                return new WebItem(By.XPath("//input[@id = 'agree_license_id']"), "чекбокс Я принимаю лицензионное соглашение");
            }
        }

        /// <summary>
        /// Текст об успешной установке обновлений
        /// </summary>
        public static WebItem Region_UpdateResult
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='upd_success_div_text' and contains(text(), 'Успешно установлено обновлений:')]"), "Текст об успешной установке обновлений");
            }
        }

        /// <summary>
        /// Прогресс бар обновления
        /// </summary>
        public static WebItem Region_UpdateProgress
        {
            get
            {
                return new WebItem(By.XPath("//div[contains(@style, 'position:relative')]"), "Прогресс бар обновления");
            }
        }

        /// <summary>
        /// Область ошибки апдейта
        /// </summary>
        public static WebItem Region_UpdateError
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='upd_error_div_text']"), "Область ошибки апдейта");
            }
        }

        /// <summary>
        /// Кнопка Журнал обновлений
        /// </summary>
        public static WebItem Button_UpdateLog
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='btn_update_log']"), "Кнопка Журнал обновлений");
            }
        }

        /// <summary>
        /// Кнопка Проверить обновления
        /// </summary>
        public static WebItem Button_CheckUpdate
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='btn_update']"), "Кнопка Проверить обновления");
            }
        }

        /// <summary>
        /// Значени мета тега http-equiv=Content-Type
        /// </summary>
        public static WebItem MetaTagHttpEq
        {
            get
            {
                return new WebItem(By.XPath("//meta[@http-equiv='Content-Type']"), "Значени мета тега http-equiv=Content-Type");
            }
        }

        /// <summary>
        /// Вкладка Настройка управляемого кеширования 
        /// </summary>
        public static WebItem Button_SelectableCasheTab
        {
            get
            {
                return new WebItem(By.XPath("//span[contains(@title, 'Настройка управляемого кеширования')]"), "Вкладка Настройка управляемого кеширования");
            }
        }

        /// <summary>
        /// Вкладка Очистка файлов кеша
        /// </summary>
        public static WebItem Button_СasheResetTab
        {
            get
            {
                return new WebItem(By.XPath("//span[contains(@title, 'Очистка файлов кеша')]"), "Вкладка Очистка файлов кеша");
            }
        }

        /// <summary>
        /// Переключатель все
        /// </summary>
        public static WebItem Button_СasheAll
        {
            get
            {
                return new WebItem(By.XPath("//input[@value='all']"), "Переключатель все");
            }
        }

        /// <summary>
        /// Кнопка начать
        /// </summary>
        public static WebItem Button_StartClearCashe
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='start_button']"), "Кнопка начать");
            }
        }

        /// <summary>
        /// Кнопка включить/выключить управляемый кэш
        /// </summary>
        public static WebItem Button_SelectableCashe
        {
            get
            {
                return new WebItem(By.XPath("//input[contains(@value, 'управляемый кеш')]"), "Кнопка включить/выключить управляемый кэш");
            }
        }

        /// <summary>
        /// Область включенного управляемого кэша
        /// </summary>
        public static WebItem Region_SelectableCasheOn
        {
            get
            {
                return new WebItem(By.XPath("//b[text()='Управляемый кеш компонентов включен.']"), "Область включенного управляемого кэша");
            }
        }

        /// <summary>
        /// Область отключенного управляемого кэша
        /// </summary>
        public static WebItem Region_SelectableCasheOff
        {
            get
            {
                return new WebItem(By.XPath("//b[text()='Управляемый кеш компонентов выключен (не рекомендуется).']"), "Область отключенного управляемого кэша");
            }
        }
    }
}