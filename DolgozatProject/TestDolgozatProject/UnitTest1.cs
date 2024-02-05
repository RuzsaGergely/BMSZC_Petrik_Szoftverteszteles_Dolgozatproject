using DolgozatProject;

namespace TestDolgozatProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PontFelveszPass()
        {
            Dolgozat dolgozat = new Dolgozat();
            try
            {
                dolgozat.PontFelvisz(10);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();

        }

        [Test]
        public void PontFelveszFail()
        {
            Dolgozat dolgozat = new Dolgozat();
            try
            {
                dolgozat.PontFelvisz(-200);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void MindenkiMegirtaPass()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvisz(100);
            dolgozat.PontFelvisz(21);
            dolgozat.PontFelvisz(-1);
            dolgozat.PontFelvisz(-1);
            dolgozat.PontFelvisz(55);
            dolgozat.PontFelvisz(80);
            dolgozat.PontFelvisz(90);
            dolgozat.PontFelvisz(90);
            dolgozat.PontFelvisz(90);

            if (dolgozat.MindenkiMegirta())
            {
                Assert.Fail();
            } else
            {
                Assert.Pass();
            }
        }

        [Test]
        public void MindenkiMegirtaFail()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvisz(100);
            dolgozat.PontFelvisz(21);
            dolgozat.PontFelvisz(55);
            dolgozat.PontFelvisz(80);
            dolgozat.PontFelvisz(90);
            dolgozat.PontFelvisz(90);
            dolgozat.PontFelvisz(90);

            if (dolgozat.MindenkiMegirta())
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void GyanusTeszt()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvisz(100);
            dolgozat.PontFelvisz(100);
            dolgozat.PontFelvisz(55);
            dolgozat.PontFelvisz(100);
            dolgozat.PontFelvisz(90);
            dolgozat.PontFelvisz(90);
            dolgozat.PontFelvisz(90);

            if (dolgozat.Gyanus(2))
            {
                Assert.Pass();
            } else
            {
                Assert.Fail();
            }

        }
    }
}