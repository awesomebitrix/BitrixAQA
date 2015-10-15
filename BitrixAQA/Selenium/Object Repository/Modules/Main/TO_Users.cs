using BitrixAQA.General;
using BitrixAQA.Selenium.Framework;
using OpenQA.Selenium;

namespace BitrixAQA.Selenium.Object_Repository
{
    /// <summary>
    /// Класс объектов для работы с сотрудниками
    /// </summary>
    class TO_Users
    {

        #region объекты публичной части
        /// <summary>
        /// Текстбокс Имя пользователя
        /// </summary>
        public static WebItem Textbox_UserName
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='USER_NAME']"), "Текстбокс Имя пользователя");
            }
        }

        /// <summary>
        /// Текстбокс Фамилия пользователя
        /// </summary>
        public static WebItem Textbox_UserLastName
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='USER_LAST_NAME']"), "Текстбокс Фамилия пользователя");
            }
        }

        /// <summary>
        /// Текстбокс Логин
        /// </summary>
        public static WebItem Textbox_UserLogin
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='USER_LOGIN']"), "Текстбокс Логин");
            }
        }

        /// <summary>
        /// Текстбокс Пароль
        /// </summary>
        public static WebItem Textbox_Password
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='USER_PASSWORD']"), "Текстбокс Пароль");
            }
        }

        /// <summary>
        /// Текстбокс Подтверждение пароля
        /// </summary>
        public static WebItem Textbox_ConfirmPassword
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='USER_CONFIRM_PASSWORD']"), "Текстбокс Подтверждение пароля");
            }
        }

        /// <summary>
        /// Текстбокс E-Mail
        /// </summary>
        public static WebItem Textbox_UserEmail
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='USER_EMAIL']"), "Текстбокс E-Mail");
            }
        }

        /// <summary>
        /// Скрытое поле с id-капчи - значение нужно для выбора кода капчи из таблички
        /// </summary>
        public static WebItem Textbox_Hidden_Captcha_Code
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='captcha_sid']"), "Скрытое поле с id-капчи");
            }
        }

        /// <summary>
        /// Текстбокс Капча-код
        /// </summary>
        public static WebItem Textbox_Captcha
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='captcha_word']"), "Текстбокс Капча-код");
            }
        }

        /// <summary>
        /// Кнопка Регистрация
        /// </summary>
        public static WebItem Button_Register
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='bx-auth']//input[@name='Register']"), "Кнопка Регистрация");
            }
        }
        #endregion

        #region объекты админ части

        #region контекстаня панель
        /// <summary>
        /// Кнопка Добавить пользователя
        /// </summary>
        public static WebItem Button_Admin_AddNewUser
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='adm-list-table-top']//a[@id='btn_new']"), "Кнопка Добавить пользователя");
            }
        }        
        #endregion

        #region табы
        /// <summary>
        /// табы формы редактирования юзера
        /// </summary>
        /// <param name="name">название таба</param>
        public static WebItem Region_Tab(string name)
        {
            return new WebItem(By.XPath("//div[@id='user_edit_tabs']//span[contains(text(),'" + name + "')]"), "таб " + name);
        }
        #endregion

        #region таб Пользователь
        /// <summary>
        /// Текстбокс Имя
        /// </summary>
        public static WebItem Textbox_Admin_Name
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='edit1']//tr[@id='tr_NAME']//input[@name='NAME']"), "Текстбокс Имя");
            }
        }

        /// <summary>
        /// Текстбокс Фамилия
        /// </summary>
        public static WebItem Textbox_Admin_LastName
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='edit1']//tr[@id='tr_LAST_NAME']//input[@name='LAST_NAME']"), "Текстбокс Фамилия");
            }
        }

        /// <summary>
        /// Текстбокс E-Mail
        /// </summary>
        public static WebItem Textbox_Admin_Email
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='edit1']//tr[@id='tr_EMAIL']//input[@name='EMAIL']"), "Текстбокс E-Mail");
            }
        }

        /// <summary>
        /// Текстбокс Логин (мин. 3 символа)
        /// </summary>
        public static WebItem Textbox_Admin_Login
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='edit1']//tr[@id='tr_LOGIN']//input[@name='LOGIN']"), "Текстбокс Логин (мин. 3 символа)");
            }
        }

        /// <summary>
        /// Текстбокс Новый пароль
        /// </summary>
        public static WebItem Textbox_Admin_Password
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='edit1']//tr[@id='bx_pass_row']//input[@name='NEW_PASSWORD']"), "Текстбокс Новый пароль");
            }
        }

        /// <summary>
        /// Текстбокс Подтверждение нового пароля
        /// </summary>
        public static WebItem Textbox_Admin_ConfirmPassword
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='edit1']//tr[@id='bx_pass_confirm_row']//input[@name='NEW_PASSWORD_CONFIRM']"), "Текстбокс Подтверждение нового пароля");
            }
        }
        #endregion

        #region таб Группы
        /// <summary>
        /// чекбокс группа пользователей
        /// </summary>
        /// <param name="group_name">название группы пользователей</param>
        public static WebItem Checkbox_Admin_Group(string group_name)
        {
            return new WebItem(By.XPath("//div[@id='edit2']//label[contains(text(),'" + group_name + "')]//..//..//label[@class='adm-designed-checkbox-label']"), "Чекбокс " + group_name);
        }
        #endregion

        #region кнопки управления
        /// <summary>
        /// Кнопка Сохранить
        /// </summary>
        public static WebItem Button_Admin_Save
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='user_edit_buttons_div']//input[@name='save']"), "Кнопка Сохранить");
            }
        }
        #endregion

        /// <summary>
        /// Область с ошибками сохранения
        /// </summary>
        public static WebItem Region_Admin_Info
        {
            get
            {
                return new WebItem(By.XPath("//div[@class='adm-info-message']"), "Область с ошибками сохранения");
            }
        }

        /// <summary>
        /// чекбокс пользователя
        /// </summary>
        /// <param name="edition">Редакция</param>
        /// <param name="DBType">Тип базы</param>
        /// <param name="user_name">имя юзера</param>
        /// <param name="user_lastname">фамилия юзера</param>
        public static WebItem Checkbox_Admin_User(string DBType, string edition, string user_name, string user_lastname)
        {
            string user_id = SQL.SQLQuery(DBType, edition, "SELECT ID FROM b_user WHERE NAME = '" + user_name + "' AND LAST_NAME = '" + user_lastname + "'");
            return new WebItem(By.XPath("//table[@id='tbl_user']//input[@name='ID[]' and @value='" + user_id + "']//..//..//td"), "Чекбокс пользователя с id равным " + user_id);
        }

        /// <summary>
        /// Кнопка Удалить в меню действий 
        /// </summary>
        public static WebItem Button_Admin_Delete
        {
            get
            {
                return new WebItem(By.XPath("//div[@id='tbl_user_footer']//a[@id='action_delete_button']"), "Кнопка Удалить в меню действий");
            }
        }

        /// <summary>
        /// ссылка с емайлом пользователя
        /// </summary>
        /// <param name="email">емайл пользователя</param>
        public static WebItem Link_Admin_UserEmail(string email)
        {
            return new WebItem(By.XPath("//table[@id='tbl_user']//td[@class='adm-list-table-cell']//a[contains(text(),'" + email + "')]"), "Ссылка с емайлом юзера " + email);
        }

        /// <summary>
        /// область со списком юзеров в админке
        /// </summary>
        public static WebItem Region_Admin_UsersList
        {
            get
            {
                return new WebItem(By.XPath("//table[@id='tbl_user']"), "область со списком юзеров в админке");
            }
        }
        #endregion

    }
}
