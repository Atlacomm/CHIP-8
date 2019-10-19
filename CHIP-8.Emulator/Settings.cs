using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace CHIP8
{
    class Settings
    {
        [JsonProperty("Buttons")]
        public Keys[] Buttons = new Keys[] { Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F };

        [JsonProperty("Sound")]
        public bool Sound = true;

        public void SaveToFile(string path)
        {
            string data = JsonConvert.SerializeObject(this, Formatting.None);
            File.WriteAllText(path, data);
        }

        public static Settings LoadFromFile(string path)
        {
            string data = File.ReadAllText(path);
            Settings settings = JsonConvert.DeserializeObject<Settings>(data);
            return settings;
        }
    }
}
