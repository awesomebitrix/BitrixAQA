﻿using BitrixAQA.Selenium.Framework;
using OpenQA.Selenium;

namespace BitrixAQA.Selenium.Object_Repository
{
    /// <summary>
    /// Класс объектов для навигации в левом меню админки
    /// </summary>
    class TO_AdminLeftMenu
    {

        #region объекты основогого меню
        /// <summary>
        /// основной пункт левого админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_LeftMenu(string name)
        {
            return new WebItem(By.XPath("//div[@class='adm-main-menu']//div[@class='adm-main-menu-item-text' and contains(text(),'" + name + "')]//.."), "основной пункт левого админ меню " + name);
        }
        #endregion

        #region объекты подменю
        /// <summary>
        /// свернутый пункт админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_TernMenuSection(string name)
        {
            return new WebItem(By.XPath("//div[@class='adm-sub-submenu-block']//div[@class='adm-submenu-item-name']//a//span[@class='adm-submenu-item-name-link-text' and text() = '" + name + "']"),
                "свернутый пункт админ меню " + name);
        }

        /// <summary>
        /// свернутый пункт админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_TernMenuSection_Store(string name)
        {
            return new WebItem(By.XPath("//div[@id='_global_menu_store']//div[@class='adm-sub-submenu-block']//div[@class='adm-submenu-item-name']//a//span[@class='adm-submenu-item-name-link-text' " +
                "and contains(text(),'" + name + "')]"), "свернутый пункт админ меню " + name);
        }

        /// <summary>
        /// развернутый пункт админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_ExpandMenuSection(string name)
        {
            return new WebItem(By.XPath("//div[@class='adm-sub-submenu-block adm-sub-submenu-open']//div[@class='adm-submenu-item-name']//a//span[@class='adm-submenu-item-name-link-text' " +
                "and contains(text(),'" + name + "')]"), "развернутый пункт админ меню " + name);
        }

        /// <summary>
        /// развернутый пункт админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_ExpandMenuSection_Store(string name)
        {
            return new WebItem(By.XPath("//div[@id='global_submenu_store']//div[@class='adm-sub-submenu-block adm-sub-submenu-open']//div[@class='adm-submenu-item-name']//a" +
                "//span[@class='adm-submenu-item-name-link-text' and contains(text(),'" + name + "')]"), "развернутый пункт админ меню " + name);
        }

        /// <summary>
        /// свернутый пункт админ подменю
        /// </summary>
        /// <param name="name">название пункта</param>
        /// <param name="globalmenu">Глобальная секция меню</param>
        public static WebItem Region_Admin_TernMenuSubSection(string name, string globalmenu = null)
        {
            if(globalmenu ==null)
                return new WebItem(By.XPath("//div[contains(@class, 'adm-sub-submenu-block adm-submenu-level-2') and not(contains(@class, 'adm-sub-submenu-open'))]//div[@class='adm-submenu-item-name']" +
                    "//span[contains(text(),'" + name + "')]"), "свернутый пункт админ подменю " + name);
            else
                return new WebItem(By.XPath("//div[@id='" + globalmenu + "']//div[contains(@class, 'adm-sub-submenu-block adm-submenu-level-2') and not(contains(@class, 'adm-sub-submenu-open'))]" +
                    "//div[@class='adm-submenu-item-name']//span[contains(text(),'" + name + "')]"), "свернутый пункт админ подменю " + name);
        }

        /// <summary>
        /// свернутый пункт админ подменю. раскрыть
        /// </summary>
        /// <param name="name">название пункта</param>
        /// <param name="globalmenu">Глобальная секция меню</param>
        public static WebItem Region_Admin_TernMenuSubSection_Show(string name, string globalmenu = null)
        {
            if (globalmenu == null)
                return new WebItem(By.XPath("//div[contains(@class, 'adm-sub-submenu-block adm-submenu-level-2') and not(contains(@class, 'adm-sub-submenu-open'))]//div[@class='adm-submenu-item-name']" +
                    "//span[contains(text(),'" + name + "')]//..//..//span[@class='adm-submenu-item-arrow-icon']"), "свернутый пункт админ подменю " + name + " . раскрыть");
            else
                return new WebItem(By.XPath("//div[@id='" + globalmenu + "']//div[contains(@class, 'adm-sub-submenu-block adm-submenu-level-2') and not(contains(@class, 'adm-sub-submenu-open'))]" +
                    "//div[@class='adm-submenu-item-name']//span[contains(text(),'" + name + "')]//..//..//span[@class='adm-submenu-item-arrow-icon']"), "свернутый пункт админ подменю " + name +
                    " . раскрыть");
        }

        /// <summary>
        /// развернутый пункт админ подменю
        /// </summary>
        /// <param name="name">название пункта</param>
        /// <param name="globalmenu">Глобальная секция меню</param>
        public static WebItem Region_Admin_ExpandMenuSubSection(string name, string globalmenu = null)
        {
            if (globalmenu == null)
                return new WebItem(By.XPath("//div[contains(@class, 'adm-sub-submenu-block adm-submenu-level-2 adm-sub-submenu-open')]//div[@class='adm-submenu-item-name']//span[contains(text(),'" +
                    name + "')]"), "развернутый пункт админ подменю " + name);
            else
                return new WebItem(By.XPath("//div[@id='" + globalmenu + "']//div[contains(@class, 'adm-sub-submenu-block adm-submenu-level-2 adm-sub-submenu-open')]" +
                    "//div[@class='adm-submenu-item-name']//span[contains(text(),'" + name + "')]"), "развернутый пункт админ подменю " + name);
        }

        /// <summary>
        /// пункт админ подменю 3 уровня 
        /// </summary>
        /// <param name="name">название пункта</param>
        /// <param name="globalmenu">Глобальная секция меню</param>
        public static WebItem Region_Admin_SubSubMenuItem(string name, string globalmenu = null)
        {
            if (globalmenu == null)
                return new WebItem(By.XPath("//div[contains(@class,'adm-sub-submenu-block adm-submenu-level-3')]//span[contains(text(),'" + name + "')]"), "пункт админ подменю 3 уровня  " + name);
            else
                return new WebItem(By.XPath("//div[@id='" + globalmenu + "']//div[@class='adm-sub-submenu-block adm-submenu-level-2 adm-sub-submenu-open']" +
                    "//div[contains(@class,'adm-sub-submenu-block adm-submenu-level-3')]//span[contains(text(),'" + name + "')]"), "пункт админ подменю 3 уровня  " + name);
        }

        /// <summary>
        /// пункт развернутого админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_SubMenuItem(string name)
        {
            return new WebItem(By.XPath("//div[contains(@class,'adm-sub-submenu-block adm-sub-submenu-open')]//div[@class='adm-sub-submenu-block-children']//span[contains(text(),'" + name + "')]"),
                "пункт развернутого админ меню " + name);
        }

        /// <summary>
        /// Кнопка раскрытия пункта развернутого админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Buton_Admin_SubMenuItem_Expand(string name)
        {
            return new WebItem(By.XPath("//div[contains(@class,'adm-sub-submenu-block adm-sub-submenu-open')]//div[@class='adm-sub-submenu-block-children']//span[contains(text(),'" + name +
                "')]//..//..//span[@class='adm-submenu-item-arrow-icon']"), "Кнопка раскрытия пункта развернутого админ меню " + name);
        }

        /// <summary>
        /// пункт развернутого админ меню
        /// </summary>
        /// <param name="name">название пункта</param>
        /// <param name="section">название секции</param>
        public static WebItem Region_Admin_SubMenuItem(string section, string name)
        {
            return new WebItem(By.XPath("//div[contains(@class,'adm-sub-submenu-block adm-sub-submenu-open')]//span[contains(text(),'" + section + "')]//..//..//.." +
                "//div[@class='adm-sub-submenu-block-children']//span[contains(text(),'" + name + "')]"), "пункт развернутого админ меню " + name);
        }

        /// <summary>
        /// пункт развернутого админ под меню
        /// </summary>
        /// <param name="name">название пункта</param>
        /// <param name="sub_name">название подпункта</param>
        public static WebItem Button_Admin_SubMenuSubItem(string name, string sub_name)
        {
            return new WebItem(By.XPath("//span[contains(text(), '" + name + "')]//..//..//..//div[@class='adm-sub-submenu-block-children']//span[contains(text(),'" + sub_name + "')]"),
                "пункт развернутого админ меню " + sub_name);
        }

        /// <summary>
        /// пункт меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_Menu(string name)
        {
            return new WebItem(By.XPath("//div[contains(@class, 'adm-global-submenu adm-global-submenu-active')]//div[@class='adm-submenu-items-block']//span[contains(text(),'" + name + "')]"),
                "пункт меню " + name);
        }

        /// <summary>
        /// пункт меню Обновление платформы
        /// </summary>
        public static WebItem Region_Admin_MenuUpdate
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='global_submenu_marketPlace']//div[@class='adm-submenu-items-block']//span[contains(text(),'Обновление платформы')]"),
                    "пункт меню Обновление платформы");
            }
        }

        /// <summary>
        /// пункт меню Обновление решений
        /// </summary>
        public static WebItem Region_Admin_MenuUpdatePartner
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='global_submenu_marketPlace']//div[@class='adm-submenu-items-block']//span[contains(text(),'Обновление решений')]"),
                    "пункт меню Обновление решений");
            }
        }

        /// <summary>
        /// пункт меню
        /// </summary>
        /// <param name="name">название пункта</param>
        public static WebItem Region_Admin_MenuMore(string name)
        {
            return new WebItem(By.XPath("//div[contains(@class,'adm-submenu-items-block')]//span[contains(text(),'" + name + "')]"), "пункт меню " + name);
        }

        /// <summary>
        /// Кнопка пункта меню
        /// </summary>
        /// <param name="ItemName">Пункт меню</param>
        public static WebItem Button_Admin_MenuItem(string ItemName)
        {
            return new WebItem(By.XPath("//div[@id='bx_menu_panel']//span[@class='adm-submenu-item-name-link-text' and contains(text(),'" + ItemName + "')]"), "Кнопка пункта меню " + ItemName);
        }
        #endregion

    }
}
