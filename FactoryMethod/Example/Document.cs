using System.Collections.Generic;

namespace FactoryMethod.Example
{
    /// <summary>
    /// the 'Creator' abstract class
    /// 文件擁有一個裝載頁面的私有集合
    /// </summary>
    public abstract class Document
    {
        //私有的頁面集合
        private List<Page> _pages = new List<Page>();

        //Constructor calls abstract Factory method
        public Document()
        {
            //產生頁面
            this.CreatePages();
        }

        /// <summary>
        /// return page collection
        /// </summary>
        public List<Page> Pages { get { return _pages; } }

        /// <summary>
        /// Factory Method
        /// </summary>
        public abstract void CreatePages();
    }

    #region 具體實作Creator的物件並實作工廠方法
    /// <summary>
    /// A 'ConctreteCreator' class
    /// 履歷文件擁有
    /// </summary>
    public class Resume : Document
    {
        //Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
    /// <summary>
    /// B 'ConcreteCreator' class
    /// </summary>
    public class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
    #endregion
}
