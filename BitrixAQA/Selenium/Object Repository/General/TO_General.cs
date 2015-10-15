using BitrixAQA.Selenium.Framework;
using OpenQA.Selenium;

namespace BitrixAQA.Selenium.Object_Repository
{
    /// <summary>
    /// Общие объекты
    /// </summary>
    class TO_General
    {
        /// <summary>
        /// Область body
        /// </summary>
        public static WebItem Region_Body
        {
            get
            {
                return new WebItem(By.XPath("//body"), "Область body");
            }
        }

        /// <summary>
        /// Область заголовка страницы
        /// </summary>
        public static WebItem Region_Pagetitle
        {
            get
            {
                return new WebItem(By.XPath("//h1[@id='pagetitle']"), "Область заголовка страницы");
            }
        }
        
        /// <summary>
        /// Область Вся страница
        /// </summary>
        public static WebItem Region_AllPage
        {
            get
            {
                return new WebItem(By.XPath("//html"), "Область вся страница");
            }
        }

        /// <summary>
        /// Область ошибки 404
        /// </summary>
        public static WebItem Region_404ErrorMessage
        {
            get
            {
                return new WebItem(By.XPath("//td[@class='main-column']//h1[@id='pagetitle' and contains(text(),'404 Not Found')]"), "Область ошибки 404");
            }
        }

        /// <summary>
        /// Область ошибки Index file is not found.
        /// </summary>
        public static WebItem Region_NotFound
        {
            get
            {
                return new WebItem(By.XPath("//body[contains(text(),'Index file is not found.')]"), "Область ошибки Index file is not found.");
            }
        }

        /// <summary>
        /// Область главной колонки
        /// </summary>
        public static WebItem Region_MainColumn
        {
            get
            {
                return new WebItem(By.XPath("//td[@class='main-column']"), "Область главной колонки");
            }
        }

        /// <summary>
        /// Область картинки в главной колонки
        /// </summary>
        /// <param name="Source">Сорс картинки</param>
        public static WebItem Region_MainColumn_Image(string Source)
        {
                return new WebItem(By.XPath("//td[@class='main-column']//img[@src='" + Source + "']"), "Область картинки в главной колонки");
        }

        /// <summary>
        /// Область ошибки при логине
        /// </summary>
        public static WebItem Region_ErrorLogin
        {
            get
            {
                return new WebItem(By.XPath("//div[@class = 'errortext']"), "Область ошибки при логине");
            }
        }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        public static WebItem Region_ErrorText
        {
            get
            {
                return new WebItem(By.XPath("//div[@class = 'feed-add-error']//span[@class = 'feed-add-info-text']"), "Текст ошибки");
            }
        }

        /// <summary>
        /// Область Табличка Загрузка
        /// </summary>
        public static WebItem Region_Wait
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-core-waitwindow']"), "Область Табличка Загрузка");
            }
        }
        
        /// <summary>
        /// Область Табличка Загрузка
        /// </summary>
        public static WebItem Region_Wait_New
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='gue_wait']"), "Область Табличка Загрузка");
            }
        }

        /// <summary>
        /// Область Табличка Загрузка
        /// </summary>
        public static WebItem Region_Wait_Roller
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='wait_bx-admin-prefix']"), "Область Табличка Загрузка");
            }
        }

        /// <summary>
        /// Область Табличка Загрузка
        /// </summary>
        public static WebItem Region_WaitWindow
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='wait_window_div']"), "Область Табличка Загрузка");
            }
        }

        #region Авторизация в публичке
        /// <summary>
        /// кнопка войти
        /// </summary>
        public static WebItem Button_Enter
        {
            get
            {
                return new WebItem(By.XPath("//header[@class='bx-header']//a[contains(text(), 'Войти')]"), "кнопка войти");
            }
        }

        /// <summary>
        /// Текстбокс Логин пользователя
        /// </summary>
        public static WebItem Textbox_UserLogin
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='USER_LOGIN']"), "Текстбокс Логин пользователя");
            }
        }

        /// <summary>
        /// Текстбокс Пароль пользователя
        /// </summary>
        public static WebItem Textbox_UserPassword
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='USER_PASSWORD']"), "Текстбокс Пароль пользователя");
            }
        }

        /// <summary>
        /// Кнопка Войти
        /// </summary>
        public static WebItem Button_Login
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='Login' and @type = 'submit']"), "Кнопка Войти");
            }
        }

        /// <summary>
        /// Кнопка Выйти
        /// </summary>
        public static WebItem Button_Logout
        {
            get
            {
                return new WebItem(By.XPath("//form//table//tbody//tr//td//input[@type='submit' and @name='logout_butt']"), "Кнопка Выйти");
            }
        }

        /// <summary>
        /// Кнопка Выйти
        /// </summary>
        public static WebItem Button_Logout_Title
        {
            get
            {
                return new WebItem(By.XPath("//a[@title='Выйти' and text()='Выйти']"), "Кнопка Выйти");
            }
        }

        /// <summary>
        /// Ссылка Регистрация в форме авторизации
        /// </summary>
        public static WebItem Link_Register
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-system-auth-form']//a[contains(text(),'Регистрация')]"), "Ссылка Регистрация в форме авторизации");
            }
        }
        #endregion

        /// <summary>
        /// Кнопка Подсветка синтаксиса
        /// </summary>
        public static WebItem Button_BacklightCodeOff
        {
            get
            {
                return new WebItem(By.XPath("//a[@class='bxce-mode-link']"), "Кнопка Подсветка синтаксиса отключена");
            }
        }

        /// <summary>
        /// Кнопка Подсветка синтаксиса включена
        /// </summary>
        public static WebItem Button_BacklightCodeOn
        {
            get
            {
                return new WebItem(By.XPath("//a[@class='bxce-mode-link bxce-mode-link-on']"), "Кнопка Подсветка синтаксиса включена");
            }
        }

        /// <summary>
        /// Текстбокс Команда php
        /// </summary>
        public static WebItem Textbox_PhpCommand
        {
            get
            {
                return new WebItem(By.XPath("//textarea[@id='query']"), "Текстбокс Команда php");
            }
        }

        /// <summary>
        /// Кнопка Выполнить
        /// </summary>
        public static WebItem Button_ExecutePhpCommand
        {
            get
            {
                return new WebItem(By.XPath("//input[@name='execute']"), "Кнопка Выполнить");
            }
        }

        /// <summary>
        /// Пункт горизонтального меню
        /// </summary>
        /// <param name="MenuItem"> Название пункта</param>
        public static WebItem Button_HorizontalMenuItem(string MenuItem)
        {
            return new WebItem(By.XPath("//ul[@id='horizontal-multilevel-menu']//a[contains(text(), '" + MenuItem + "')]"), "Пункт горизонтального меню " + MenuItem);
        }

        /// <summary>
        /// Пункт левого меню
        /// </summary>
        /// <param name="MenuItem"> Название пункта</param>
        public static WebItem Button_LeftMenuItem(string MenuItem)
        {
            return new WebItem(By.XPath("//ul[@class='left-menu']//a[contains(text(), '" + MenuItem + "')]"), "Пункт левого меню " + MenuItem);
        }

        /// <summary>
        /// Текстбокс URL сайта
        /// </summary>
        public static WebItem Textbox_ServerName
        {
            get
            {
                return new WebItem(By.XPath("//input[@type='text' and @name='server_name']"), "Текстбокс URL сайта");
            }
        }

        /// <summary>
        /// Текстбокс поиск
        /// </summary>
        public static WebItem Textbox_Search
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='search-form']//input[@type='text']"), "Текстбокс поиск");
            }
        }

        /// <summary>
        /// Текстбокс поиск
        /// </summary>
        public static WebItem Textbox_Search_Admin
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='bx-search-input']"), "Текстбокс поиск");
            }
        }

        /// <summary>
        /// Область выпадающих подсказок поиска
        /// </summary>
        public static WebItem Region_SearchHelp
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='adm-search-result-wrap']"), "Область выпадающих подсказок поиска");
            }
        }

        /// <summary>
        /// Выпадающая подсказка поиска
        /// </summary>
        /// <param name="RowName">Имя трочки</param>
        public static WebItem Region_SearchHelp_Row(string RowName)
        {
            return new WebItem(By.XPath("//td[@class='adm-search-item' and @title='" + RowName + "']"), "Выпадающая подсказка поиска");
        }

        /// <summary>
        /// Кнопка поиск
        /// </summary>
        public static WebItem Button_Search
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='search-form']//input[@type='submit']"), "Кнопка поиск");
            }
        }

        /// <summary>
        /// Кнопка переиндексировать
        /// </summary>
        public static WebItem Button_Reindex
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='start_button' and @onclick='StartReindex();']"), "Кнопка переиндексировать");
            }
        }

        /// <summary>
        /// Кнопка Начать индексацию
        /// </summary>
        public static WebItem Button_Index
        {
            get
            {
                return new WebItem(By.XPath("//input[@id='btn_start' and @onclick='StartIndex()']"), "Кнопка Начать индексацию");
            }
        }

        /// <summary>
        /// Область количества найденных файлов
        /// </summary>
        /// <param name="Amounth">Ожидаеммое коство</param>
        public static WebItem Region_SearchedAmount(int Amounth)
        {
            return new WebItem(By.XPath("//div[@class='search-page']//font[@class='text' and contains(text(), 'из " + Amounth.ToString() + "')]"), "Область количества найденных файлов");
        }

        /// <summary>
        /// Область результата переиндексации
        /// </summary>
        public static WebItem Region_ReindexResult
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='reindex_result']"), "Область уведомления");
            }
        } 

        /// <summary>
        /// Область найденной строки
        /// </summary>
        /// <param name="Href"> Ссылка в заголовке найденной строки</param>
        /// <param name="Text"> Текст найденной строки </param>
        public static WebItem Region_SearchedRow(string Href, string Text)
        {
            return new WebItem(By.XPath("//div[@class='search-page']//a[contains(@href, '" + Href + "') and contains(text(), '" + Text + "')]"), "Область найденной строки");
        }

        /// <summary>
        /// Область найденного тега
        /// </summary>
        /// <param name="Text"> Текст тега </param>
        public static WebItem Region_SearchedTeg(string Text)
        {
            return new WebItem(By.XPath("//a[contains(text(), '" + Text + "')]"), "Область найденного тега");
        }

        /// <summary>
        /// Область найденных данных
        /// </summary>
        public static WebItem Region_Searched
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='search-page']"), "Область найденных данных");
            }
        }

        /// <summary>
        /// Область найденных данных
        /// </summary>
        public static WebItem Region_SearchedResult
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='search-page']/table"), "Область найденных данных");
            }
        }

        /// <summary>
        /// Область напоминания otp
        /// </summary>
        public static WebItem Region_OTP
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='otpInfoPopup']"), "Область напоминания otp");
            }
        }

        /// <summary>
        /// Кнопка Напомнить позже
        /// </summary>
        public static WebItem Button_RemindLater
        {
            get
            {
                return new WebItem(By.XPath("//a[text()='Напомнить позже']"), "Кнопка Напомнить позже");
            }
        }
    }
}
