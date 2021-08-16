using CoreClass;

namespace DoIt
{
    public class DoBuilder
    {
        public static void Do()
        {
            Builder b1 = new Gundam00();
            Builder b2 = new GundamUC();
            Director d = new Director();

            GumdanProduct p1 = d.Command(b1);
            GumdanProduct p2 = d.Command(b2);

            p1.Show();
            p2.Show();
        }
    }
}
