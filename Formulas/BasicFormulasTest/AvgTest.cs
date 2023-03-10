using BasicFormulas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace BasicFormulasTest
{
    /// <summary>
    /// Unit tests for the BasicFormulas.Avg class.
    /// </summary>
    [TestClass]
    public class AvgTest
    {
        [TestMethod]
        public void MovAvgTest()
        {
            const int PointCount = 3;
            Avg avg = new Avg();

            avg.SetCurCnl(1, 1.0, 1);
            avg.MovAvg(PointCount);

            avg.SetCurCnl(1, 2.0, 1);
            avg.MovAvg(PointCount);

            avg.SetCurCnl(1, 3.0, 1);
            avg.MovAvg(PointCount);

            avg.SetCurCnl(1, 4.0, 1);
            avg.MovAvg(PointCount);

            avg.SetCurCnl(1, 5.0, 1);
            double actualResult = avg.MovAvg(PointCount);
            Assert.AreEqual(4.0, actualResult);
        }

        [TestMethod]
        public void TimeAvgTest()
        {
            const int TimeSpanSec = 1;
            const int PointCount = 10;
            Avg avg = new Avg();

            avg.SetCurCnl(1, 1.0, 1);
            avg.TimeAvg(TimeSpanSec, PointCount);
            Thread.Sleep(300);

            avg.SetCurCnl(1, 2.0, 1);
            avg.TimeAvg(TimeSpanSec, PointCount);
            Thread.Sleep(300);

            avg.SetCurCnl(1, 3.0, 1);
            avg.TimeAvg(TimeSpanSec, PointCount);
            Thread.Sleep(300);

            avg.SetCurCnl(1, 4.0, 1);
            avg.TimeAvg(TimeSpanSec, PointCount);
            Thread.Sleep(300);

            avg.SetCurCnl(1, 5.0, 1);
            double actualResult = avg.TimeAvg(TimeSpanSec, PointCount);
            Assert.AreEqual(3.5, actualResult);
        }
    }
}
