using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lafitness.UIElements
{
    public class FindUIElements
    {
        #region URL
        public const string BaseURL = "http://test3.lafitness.com";
        #endregion

        #region TopMenu About LA Fitness
        public const string AboutLAFit = "ABOUT LA FITNESS";
        public const string AboutLAFWhyJoin = "//div//a[@href='/Pages/whyJoin.aspx']";
        public const string AboutLAFHistory = "//div//a[@href='/Pages/about.aspx']";
        public const string FindClub = "//div//a[@href='/Pages/findclub.aspx']";
        public const string FindClubByZipCode = "ctl00_MainContent_FindAClub1_txtZipCode";
        #endregion

        #region MemberLogin
        public const string MemberLoginBtn = "//div//a[@id='ctl00_GlobalHeader_lnkLogin']";
        public const string UserName = "cyn.ferr";
        public const string Password = "Fitness1";
        public const string UserNameField = "txtUser2";
        public const string PasswordField = "txtPassword2";
        public const string SignInBtn = "ctl00_MainContent_Login1_btnLogin2";

        #endregion

        #region FindClub
        public const string FindClubByZip = "91765";
        public const string clubByZipFindBtn = "ctl00_MainContent_FindAClub1_lnkBtnGo";
        public const string DiamondBarClubLinkText = "Diamond Bar";
        public const string clubSortBy = "//div//select[@id='ctl00_MainContent_ddlSortBy']";
        public const string clubSortByCity = "//div//select[@id='ctl00_MainContent_ddlSortBy']//option[2]";
        //public const string clubSortByCity = "City";
        public const string clubSortByClub = "Club";
        public const string clubSortByDistance = "Distance";
        public const string listOfAmenities = "//div[@id='amenities']/ul/li";
        #endregion
    }
}
