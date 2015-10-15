using BitrixAQA.Selenium.Framework;
using OpenQA.Selenium;

namespace BitrixAQA.Selenium.Object_Repository
{
    /// <summary>
    /// Объекты админ панели
    /// </summary>
    class TO_AdminPanel
    {
        /// <summary>
        /// Кнопка Добавить новое решение
        /// </summary>
        public static WebItem Button_AddNewSolution
        {
            get
            {
                return new WebItem(By.XPath("//a[contains(@href,'/?add_new_site_sol=sol&sessid=')]"), "Кнопка Добавить новое решение");
            }
        }

        /// <summary>
        /// Таб Сайт в публичной части
        /// </summary>
        public static WebItem Tab_PublicViewTab
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx-panel-view-tab']"), "Таб Сайт");
            }
        }

        /// <summary>
        /// Таб Администрирование в публичной части
        /// </summary>
        public static WebItem Tab_PublicAdminTab
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx-panel-admin-tab']"), "Таб Администрирование");
            }
        }

        /// <summary>
        /// Таб Сайт в административной части
        /// </summary>
        public static WebItem Tab_AdminViewTab
        {
            get
            {
                return new WebItem(By.XPath("//a[@class='adm-header-btn adm-header-btn-site']"), "Таб Сайт");
            }
        }

        /// <summary>
        /// Таб Администрирование в административной части
        /// </summary>
        public static WebItem Tab_AdminAdminTab
        {
            get
            {
                return new WebItem(By.XPath("//a[@class='adm-header-btn adm-header-btn-admin']"), "Таб Администрирование");
            }
        }

        /// <summary>
        /// Кнопка Настройки
        /// </summary>
        public static WebItem Button_Settings
        {
            get
            {
                return new WebItem(By.XPath("//a[@class='adm-header-setting-btn']"), "Кнопка Настройки");
            }
        }

        /// <summary>
        /// Кнопка Настройки (старая)
        /// </summary>
        public static WebItem Button_SettingsOLD
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx-panel-admin-button-settings-icon-id']"), "Кнопка Настройки Старая");
            }
        }

        /// <summary>
        /// Кнопка Настройки модуля
        /// </summary>
        public static WebItem Button_ModuleSettings
        {
            get
            {
                return new WebItem(By.XPath("//body//div[@class='bx-popup-menu']//table[@class='bx-popup-menu-wrapper']//tbody//tr//td[@class='bx-popup-menu']" +
                    "//table[@class='bx-popup-menu-layout']//tbody//tr//td//div[@class='bx-popup-item']"), "Кнопка Настройки модуля");
            }
        }

        /// <summary>
        /// Кнопка Сбросить кеш
        /// </summary>
        public static WebItem Button_ClearCache
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-panel-button-icon bx-panel-clear-cache-icon']"), "Кнопка Сбросить кеш");
            }
        }

        /// <summary>
        /// Кнопка меню мастера портала
        /// </summary>
        public static WebItem Button_MasterMenu
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx_topmenu_btn_portal_wizard_menu']"), "Кнопка меню мастера портала");
            }
        }

        /// <summary>
        /// Кнопка Логаут
        /// </summary>
        public static WebItem Button_Logout
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx-panel-logout']"), "Кнопка Выйти");
            }
        }

        /// <summary>
        /// Кнопка Компоненты
        /// </summary>
        public static WebItem Button_Components
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx_topmenu_btn_components']"), "Кнопка Компоненты");
            }
        }

        /// <summary>
        /// Пункт выпадающего меню Компоненты
        /// </summary>
        /// <param name="componentName">название компонента</param>
        public static WebItem Button_ComponentSelect(string componentName)
        {
            return new WebItem(By.XPath("//div[@class='bx-core-popup-menu bx-core-popup-menu-bottom bx-core-popup-menu-level0 bx-core-popup-menu-no-icons' and contains(@style, 'display: block;')]" +
                "//span[@class='bx-core-popup-menu-item-text' and contains(text(), '" + componentName + "')]"), "Пункт выпадающего меню компоненты " + componentName);
        }

        /// <summary>
        /// Режим правки
        /// </summary>
        public static WebItem Button_EditMode
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx-panel-toggle']"), "Режим правки");
            }
        }

        #region Редактирование страниц и разделов
        /// <summary>
        /// Кнопка Создать страницу
        /// </summary>
        public static WebItem Button_NewPage
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-panel-button-icon bx-panel-create-page-icon']"), "Кнопка Создать страницу");
            }
        }

        /// <summary>
        /// Кнопка Создать раздел
        /// </summary>
        public static WebItem Button_NewSection
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-panel-button-icon bx-panel-create-section-icon']"), "Кнопка Создать раздел");
            }
        }

        /// <summary>
        /// Кнопка Изменить страницу
        /// </summary>
        public static WebItem Button_EditPage
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx_topmenu_btn_edit']"), "Кнопка Изменть страницу");
            }
        }

        /// <summary>
        /// Кнопка Меню Изменить страницу
        /// </summary>
        public static WebItem Button_MenuEditPage
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx_topmenu_btn_edit_menu']"), "Кнопка Меню Изменить страницу");
            }
        }

        /// <summary>
        /// Кнопка Меню Изменить раздел
        /// </summary>
        public static WebItem Button_MenuEditSection
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx_topmenu_btn_edit_section_menu']"), "Кнопка Меню Изменить раздел");
            }
        }

        /// <summary>
        /// Кнопка Свойства раздела
        /// </summary>
        public static WebItem Button_SectionProps
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-core-popup-menu-item-text' and contains(text(), 'Свойства раздела')]"), "Кнопка Свойства раздела");
            }
        }

        /// <summary>
        /// Кнопка Доступ к странице
        /// </summary>
        public static WebItem Button_PageRights
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-core-popup-menu-item-text' and contains(text(), 'Доступ к странице')]"), "Кнопка Доступ к странице");
            }
        }

        /// <summary>
        /// Кнопка Доступ к разделу
        /// </summary>
        public static WebItem Button_SectionRights
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-core-popup-menu-item-text' and contains(text(), 'Доступ к разделу')]"), "Кнопка Доступ к разделу");
            }
        }

        /// <summary>
        /// Кнопка Удалить страницу
        /// </summary>
        public static WebItem Button_DeletePage
        {
            get
            {
                return new WebItem(By.XPath("//span[@class='bx-core-popup-menu-item-text' and contains(text(), 'Удалить страницу')]"), "Кнопка Удалить страницу");
            }
        }

        /// <summary>
        /// Кнопка Диалога удаления страницы Да, удалить
        /// </summary>
        public static WebItem Button_YesDelete
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='btn_popup_save']"), "Кнопка Да, удалить");
            }
        }
        #endregion

        /// <summary>
        /// Кнопка Структура
        /// </summary>
        public static WebItem Button_Structure
        {
            get
            {
                return new WebItem(By.XPath("//a[@id='bx_topmenu_btn_structure']"), "Кнопка Структура");
            }
        }

        /// <summary>
        /// Кнопка название папки в диалоге структуры сайта
        /// </summary>
        /// <param name="folderName">название папки</param>
        public static WebItem Button_Structure_Folder(string folderName)
        {
            return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//div[@id='structure_content']//div[@class='bx-struct-item']//div[@class='bx-struct-name' and contains(text(), '" +
                folderName + "')]"), "Кнопка " + folderName + " в диалоге структуры сайта");
        }

        /// <summary>
        /// Кнопка Удалить в выпадающем меню диалога структуры сайта
        /// </summary>
        public static WebItem Button_Delete_FromStructure
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='structure_menu']//table[@id='structure_menu_items']//div[@id='structure_menu_item_6']"), "Кнопка Удалить");
            }
        }

        /// <summary>
        /// Кнопка Закрыть диалог структуры сайта
        /// </summary>
        public static WebItem Button_Close_Structure
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//input[@id='close']"), "Кнопка Закрыть диалог структуры сайта");
            }
        }

        /// <summary>
        /// Область с предупреждением в публичке
        /// </summary>
        /// <param name="Message">Ожидаемое сообщение</param>
        public static WebItem Region_WarningMessage(string Message)
        {
            return new WebItem(By.XPath("//div[@id='bx-panel']//div[@class='adm-warning-block']//span[contains(text(), '" + Message + "')]"), "Область с предупреждением в публичке");
        }

        /// <summary>
        /// Кнопка Отменить изменения на области предупреждений
        /// </summary>
        /// <param name="Message">Ожидаемое сообщение</param>
        public static WebItem Button_Undo_ChangesMessage(string Message)
        {
            return new WebItem(By.XPath("//div[@id='bx-panel']//div[@class='adm-warning-block']//span[contains(text(), '" + Message + "')]//a"), "Кнопка Отменить изменения на области предупреждений");
        }

        /// <summary>
        /// Кнопка Меню
        /// </summary>
        public static WebItem Button_Menu
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-panel']//a[@id='bx_topmenu_btn_menus']"), "Кнопка Меню");
            }
        }

        /// <summary>
        /// Кнопка Вставить пункт меню в диалоге редактирования меню
        /// </summary>
        public static WebItem Button_Menu_Add_Item
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//input[@type='button' and @onclick='menuAdd()']"), "Кнопка Вставить пункт меню в диалоге редактирования меню");
            }
        }

        /// <summary>
        /// Область Название нового пункта меню в диалоге редактирования меню
        /// </summary>
        public static WebItem Textbox_Menu_ItemName
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx_menu_layout']//div[contains(@id,'view_area_text_') and contains(text(),'--- нет значения ---')]"),
                    "Область Название нового пункта меню в диалоге редактирования меню");
            }
        }

        /// <summary>
        /// Текстбокс Название нового пункта меню в диалоге редактирования меню
        /// </summary>
        public static WebItem Textbox_Menu_ItemName_Edit
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx_menu_layout']//div[contains(@id,'edit_area_text_')]//input[@value='' and contains(@name,'text_')]"),
                    "Текстбокс Название нового пункта меню в диалоге редактирования меню");
            }
        }

        /// <summary>
        /// Область Ссылка на новый пункт меню в диалоге редактирования меню
        /// </summary>
        public static WebItem Textbox_Menu_ItemLink
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx_menu_layout']//div[contains(@id,'view_area_link_') and contains(text(),'--- нет значения ---')]"),
                    "Область Ссылка на новый пункт меню в диалоге редактирования меню");
            }
        }

        /// <summary>
        /// Текстбокс Ссылка на новый пункт меню в диалоге редактирования меню
        /// </summary>
        public static WebItem Textbox_Menu_ItemLink_Edit
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx_menu_layout']//div[contains(@id,'edit_area_link_')]//input[@value='' and contains(@name,'link_')]"),
                    "Текстбокс Ссылка на новый пункт меню в диалоге редактирования меню");
            }
        }

        /// <summary>
        /// Кнопка Сохранить меню
        /// </summary>
        public static WebItem Button_Save_Menu
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//input[@id='savebtn']"), "Кнопка Сохранить меню");
            }
        }

        /// <summary>
        /// Кнопка удалить пункт меню
        /// </summary>
        /// <param name="menuitemName">название пункта</param>
        /// <returns></returns>
        public static WebItem Button_Delete_MenuItem(string menuitemName)
        {
            return new WebItem(By.XPath("//div[contains(@id, 'view_area_text_') and contains(text(), '" + menuitemName + "')]//..//..//span[@class='rowcontrol delete']"),
                "Кнопка удалить пункт меню " + menuitemName);
        }

        /// <summary>
        /// Выпадающий список с правами в диалоге прав доступа
        /// </summary>
        public static WebItem Dropdown_SelectRights
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//table[@id='bx_permission_table']//select[contains(@id, 'bx_task_list_')]"),
                    "Выпадающий список с правами в диалоге прав доступа");
            }
        }

        /// <summary>
        /// Область с правом доступа в диалоге прав доступа
        /// </summary>
        public static WebItem Textbox_Right_View
        {
            get
            {
                return new WebItem(By.XPath("//table[@id='bx_permission_table']//div[contains(@id,'bx_permission_view_')]"), "Область с правом доступа в диалоге прав доступа");
            }
        }

        /// <summary>
        /// Выпадающий список с правами доступа по умолчанию в диалоге прав доступа
        /// </summary>
        public static WebItem Dropdown_Right_Edit
        {
            get
            {
                return new WebItem(By.XPath("//table[@id='bx_permission_table']//div[contains(@id,'bx_permission_edit_')]//select[@name='PERMISSION[*]']"),
                    "Выпадающий список с правами доступа по умолчанию в диалоге прав доступа");
            }
        }

        /// <summary>
        /// Кнопка Сохранить в диалоге настройки прав
        /// </summary>
        public static WebItem Button_Save_Rights
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//input[@id='savebtn']"), "Кнопка Сохранить в диалоге настройки прав");
            }
        }

        /// <summary>
        /// Кнопка ссылка Отменить ограничения доступа для этого файла
        /// </summary>
        public static WebItem Button_ClearPageRights
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//a[contains(text(), 'Отменить ограничения доступа для этого файла')]"),
                    "Кнопка ссылка Отменить ограничения доступа для этого файла");
            }
        }

        /// <summary>
        /// Кнопка ссылка Отменить ограничения доступа для этого раздела
        /// </summary>
        public static WebItem Button_ClearSectionRights
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//a[contains(text(), 'Отменить ограничения доступа для этого раздела')]"),
                    "Кнопка ссылка Отменить ограничения доступа для этого раздела");
            }
        }

        /// <summary>
        /// Кнопка ссылка Добавить право доступа
        /// </summary>
        public static WebItem Button_Add_Rights
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//a[contains(text(), 'Добавить право доступа')]"), "Кнопка ссылка Добавить право доступа");
            }
        }

        /// <summary>
        /// Область с текстом свойства раздела в диалоге редактирования свойств раздела
        /// </summary>
        /// <param name="propName">названия свойства, например Описание страницы</param>
        public static WebItem Textbox_Prop_ItemView(string propName)
        {
            return new WebItem(By.XPath("//table[@id='bx_folder_properties']//td[contains(text(), '" + propName + "')]//..//div[contains(@id,'bx_view_property_')]"),
                "Область с текстом свойства раздела в диалоге редактирования свойств раздела");
        }

        /// <summary>
        /// Текстбокс с текстом свойства раздела в диалоге редактирования свойств раздела
        /// </summary>
        /// <param name="propName">названия свойства, например Продвигаемые слова</param>
        public static WebItem Textbox_Prop_ItemEdit(string propName)
        {
            return new WebItem(By.XPath("//table[@id='bx_folder_properties']//td[contains(text(), '" + propName + "')]//..//div//input[contains(@id, 'bx_property_input_')]"),
                "Текстбокс с текстом свойства раздела в диалоге редактирования свойств раздела " + propName);
        }

        /// <summary>
        /// Текстбокс с текстом свойства раздела в диалоге редактирования свойств раздела
        /// </summary>
        /// <param name="propName">названия свойства, например Продвигаемые слова</param>
        public static WebItem Textbox_Prop_ItemEdit_Other(string propName)
        {
            return new WebItem(By.XPath("//table[@id='bx_folder_properties']//td[contains(text(), '" + propName + "')]//..//input[contains(@name, 'PROPERTY')]"),
                "Текстбокс с текстом свойства раздела в диалоге редактирования свойств раздела " + propName);
        }

        /// <summary>
        /// Кнопка Сохранить в диалоге настройки свойств
        /// </summary>
        public static WebItem Button_Save_Props
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='bx-admin-prefix']//input[@id='savebtn']"), "Кнопка Сохранить в диалоге настройки свойств");
            }
        }
    }
}
