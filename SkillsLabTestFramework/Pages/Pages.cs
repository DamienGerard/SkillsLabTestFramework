﻿using SeleniumExtras.PageObjects;

namespace SkillsLabTestFramework
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();

            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static RegisterUserPage Register
        {
            get { return GetPage<RegisterUserPage>(); }
        }

        public static StudentProfile StudentProfile
        {
            get { return GetPage<StudentProfile>(); }
        }

        public static TeacherProfile TeacherProfile
        {
            get { return GetPage<TeacherProfile>(); }
        }

        public static AdminProfile AdminProfile
        {
            get { return GetPage<AdminProfile>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }


    }
}
