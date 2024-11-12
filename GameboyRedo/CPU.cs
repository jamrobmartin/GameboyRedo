namespace GameboyRedo
{
    public class CPU
    {
        private ControlUnit ControlUnit;
        private RegisterFile RegisterFile;
        private ALU ALU;
        private IDU IDU;

        public bool Powered { get; private set; }

        public CPU()
        {
            ControlUnit = new ControlUnit();
            RegisterFile = new RegisterFile();
            ALU = new ALU();
            IDU = new IDU();
        }
    }

    class ControlUnit
    {

    }

    class RegisterFile
    {

    }

    class ALU
    {

    }

    class IDU
    {

    }
}
