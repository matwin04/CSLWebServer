using ICities;

namespace CSLWebServer {
    public class CSLWebServer: IUserMod{
        public string Name => "CSLWebServer";
        public string Description => "A simple 'Hello World' mod for Cities: Skylines.";

        public void OnEnabled(){
            UnityEngine.Debug.Log("CSL WEB SERVER MOD ENABLED");
        }
        
    }
}