namespace BaseClasses
{
    public class GameInstance : Object
    {
        //Static Instance
        private static GameInstance Instance { get; set; }

        protected override void Initialize()
        {
            base.Initialize();

            //Dont destroy on load
            DontDestroyOnLoad(gameObject);

            //Set Instance
            Instance = this;
        }

        public static GameInstance GetGameInstance()
        {
            return Instance;
        }
    }
}