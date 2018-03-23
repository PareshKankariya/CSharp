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
        public const string BaseURL = "http://test6.lafitness.com";
        #endregion

        #region TopMenu About LA Fitness
        public const string AboutLAFit = "ABOUT LA FITNESS";
        public const string AboutLAFWhyJoin = "//div//a[@href='/Pages/whyJoin.aspx']";
        public const string AboutLAFHistory = "//div//a[@href='/Pages/about.aspx']";
        public const string CareerOpportunity = "//div//a[@href='/Pages/Employment.aspx']";
        public const string EventsNews = "//div//a[@href='/Pages/NewsAndAnnouncements.aspx']";
        public const string MediaRelations = "//div//a[@href='/Pages/PressRelease.aspx']";
        public const string Leagues = "//div//a[@href='/Pages/Leagues.aspx']";
        public const string ContactUs = "//div//a[@href='/Pages/ContactUs.aspx']";
        public const string PrivacyPolicy = "//div//a[@href='/Pages/PrivacyPolicy.aspx']";
        public const string CorporatePrograms = "//div//a[@href='/Pages/CorporateSignup.aspx']";
        public const string FindClub = "//div//a[@href='/Pages/findclub.aspx']";
        public const string FindClubByZipCode = "ctl00_MainContent_FindAClub1_txtZipCode";
        public const string AboutLAWhyJoinTitle = "LA Fitness | Fitness and Health Club | Getting in Shape | Look and Feel Your Best";
        public const string AboutLAFHistoryTitle = "LA Fitness | Reviews | Gym Membership | Pursue Fitness Goals";
        public const string CareerOpportunityTitle = "LA Fitness | Gym Jobs | Fitness Employment Opportunities";
        public const string EventsNewTitle = "LA Fitness | Reviews | Health Club News and Gym Announcements";
        public const string MediaRelationsTitle = "LA Fitness | Reviews | Gym Press Release";
        public const string LeaguesTitle = "LA Fitness | Leagues and Activities";
        public const string ContactUsTitle = "LA Fitness | Health Club Member Services | Contact Us";
        public const string PrivacyPolicyTitle = "LA Fitness | Privacy Policy";
        public const string CorporateProgramsTitle = "LA Fitness | Gym Memberships | Corporate Wellness Club Information";
        public const string MainSiteTitle = "LA Fitness | Exercise Your Options";
        #endregion

        #region Group Fitness Page
        public const string GroupFitness = "//div//a[@href='/Pages/AerobicClasses.aspx']";
        public const string GroupFitnessPageTitle = "LA Fitness | Group Fitness | Helping Gym Members Pursue Active Goals";
        public const string SelectClassDropdown = "//div//select [@id='ctl00_MainContent_DropDownListClasses']";
        public const string ZipCodeTxt = "ctl00_MainContent_txtZipCode";
        public const string ZipCode = "91765";
        public const string RadiusDropdown = "ctl00_MainContent_cbxRange";
        public const string LocateAClassBtn = "ctl00_MainContent_imgBtnGo";
        public const string DBYogaSchedule = "//div[@id='ClubHeader0']//a[@title='DIAMOND BAR schedule detail']";
        public const string DBClubHomePage = "//div[@id='ClubListContainer']//a[@href='./clubhome.aspx?clubid=14']";
        public const string BackToGroupFitnessBtn = "ctl00_MainContent_btnBack";
        #endregion

        #region SearchClubByZip
        public const string SearchClubByZip = "ctl00_GlobalHeader_txtZip";
        #endregion

        #region Personal Training Page
        public const string PersonalTraining = "//div//a[@href='/Pages/PersonalTrainingGeneral.aspx']";
        public const string PersonalTrainingPageTitle = "LA Fitness | Workout Personal Training | Find Personal Fitness Training Program";
        #endregion

        #region Member Tools
        public const string memberTools = "//div[@class='lafContent']/ul[@role='menubar']/li[4]/a";        
        public const string MemberToolsCreateOnlineAccount = "//div//li[@id='liLAFCreateAccountLAF']/a";
        public const string MemberToolsCreateOnlineAccountTitle = "LA Fitness | Member Services | Account Validation";
        public const string MemberToolsMyLAFitness = "//div//a[@href='/Pages/memberServices.aspx?task=CustomerManagement']";
        public const string MemberToolsMyLAFitnessTitle = "LA Fitness | Membership | Lifestyle Fitness | Gym Member Login";
        public const string MemberToolsMyZone = "//div//a[@href='http://myzone.lafitness.com']";
        public const string MemberToolsMyZoneTitle = "LA Fitness | Making Movement Measurable";
        public const string MemberToolsMyClub = "//div//a[@href='/Pages/SendToClubHome.aspx']";
        public const string MemberToolsMyClubTitle = "LA Fitness | Membership | Lifestyle Fitness | Gym Member Login";
        public const string MemberToolsMyPersonalTraining = "//div//a[@href='/Pages/SendToClubHome.aspx']";
        public const string MemberToolsMyPersonalTrainingTitle = "LA Fitness | Membership | Lifestyle Fitness | Gym Member Login";
        public const string MemberToolsAddVIPGuest = "//div//a[@href='/Pages/myviplist.aspx']";
        public const string MemberToolsAddVIPGuestTitle = "LA Fitness | VIP Rewards";
        public const string MemberToolsAddFamilyMember = "//div//a[@href='/Pages/OnlineMembershipFamilyAddOn.aspx']";
        public const string MemberToolsAddFamilyMemberTitle = "LA Fitness | Membership | Lifestyle Fitness | Gym Member Login";
        public const string MemberToolsBillingInformation = "//div//a[@href='/Pages/memberServices.aspx?task=BillingManagement']";
        public const string MemberToolsBillingInformationTitle = "LA Fitness | Membership | Lifestyle Fitness | Gym Member Login";
        public const string MemberToolsMembershipQuestions = "//div//a[@href='/Pages/MembershipQuestions.aspx']";
        public const string MemberToolsMembershipQuestionsTitle = "LA Fitness | Health Club Member Services | Membership Questions";
        public const string MemberToolsMobileApp = "//div//a[@href='/Pages/MembershipQuestions.aspx']";
        public const string MemberToolsMobileAppTitle = "LA Fitness | Membership | Lifestyle Fitness | Gym Member Login";
        #endregion


        #region Social media Page
        public const string SocialMediaMenu = "//div[@id='ctl00_GlobalHeader_LAFmenuList']/ul/li[5]/a";
        public const string SocialMediaMenuOverview = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='/Pages/SocialMedia.aspx?Source=7']";
        public const string SocialMediaMenuLivingHealthy = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='http://blog.lafitness.com/']";
        public const string SocialMediaMenuFacebook = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='https://www.facebook.com/LAFitness']";
        public const string SocialMediaMenuTwitter = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='https://twitter.com/lafitness']";
        public const string SocialMediaMenuYouTube = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='http://www.youtube.com/lafitness']";
        public const string SocialMediaMenuGooglePlus = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='https://plus.google.com/107619435087254261085']";
        public const string SocialMediaMenuInstagram = "//div[@id='ctl00_GlobalHeader_LAFmenuList']//a[@href='http://instagram.com/lafitness']";
        #endregion

        #region Shop LAFitness
        public const string shopLAFitness = "//div[@id = 'ctl00_GlobalHeader_LAFmenuList']//a[@href='http://shoplafitness.com/']";
        #endregion

        #region MemberLogin
        public const string MemberLoginBtn = "//div//a[@id='ctl00_GlobalHeader_lnkLogin']";
        public const string UserName = "irvine01";
        public const string Password = "Fitness1";
        public const string UserNameField = "txtUser";
        public const string PasswordField = "txtPassword";
        public const string SignInBtn = "ctl00_MainContent_Login1_btnLogin";
        #endregion

        #region MembershipFunctions
        public const string AccountInformationProfile = "//div[@id='ctl00_MainContent_UpdatePanel1']/ul/li[3]/a";
        public const string AccountInformationFacebook = "//div[@id='ctl00_MainContent_UpdatePanel1']/ul/li[5]/a";
        public const string AccountInformationNotifications = "//div[@id='ctl00_MainContent_UpdatePanel1']/ul/li[7]/a";
        public const string MyHome = "//div[@id='myFitnessBody']//a[@id='HomeTab']";
        public const string Calendar = "//div[@id='myFitnessBody']//a[@id='ScheduleTab']";
        public const string FitnessFriends = "//div[@id='myFitnessBody']//a[@id='GymTab']";
        public const string LeaguesAndActivities = "//div[@id='myFitnessBody']//a[@id='LeagueTab']";
        public const string ArticlesAndVideos = "//div[@id='myFitnessBody']//a[@id='ArticlesTab']";
        public const string ViewMyCalendar = "//div[@id='myFitnessBody']//div[@class='helpmenuContainer']/ul[1]/li[1]/a";
        public const string AddWorkout = "//div[@id='myFitnessBody']//div[@class='helpmenuContainer']/ul[1]/li[2]/a";
        public const string AddGroupFitnessClass = "//div[@id='myFitnessBody']//div[@class='helpmenuContainer']/ul[1]/li[3]/a";
        public const string BookPrivateTraining = "//div[@id='myFitnessBody']//div[@class='helpmenuContainer']/ul[1]/li[4]/a";
        public const string ReserveACourt = "//div[@id='myFitnessBody']//div[@class='helpmenuContainer']/ul[1]/li[5]/a";
        public const string Leagues = "//div[@id='myFitnessBody']//div[@class='helpmenuContainer']/ul[1]/li[6]/a";


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

        #region Find Class
        public const string findClassPage = "//div[@id='ctl00_GlobalHeader_LAFmenuList']/ul/li[8]/a[@href='/Pages/LocateClassNearYou.aspx']";
        public const string findClassDropDown = "DropDownListClasses";
        public const string findClassZipCodeTxtBox = "txtZipCode";
        public const string findClassRadiusDropDown = "cbxRange";
        public const string findBtn = "btnFind";
        public const string DBClubClassLink = "//div[@id='ClubHeader0']/a[@title = 'DIAMOND BAR schedule detail']";
        #endregion
    }
}
