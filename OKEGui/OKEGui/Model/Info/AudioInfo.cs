﻿using OKEGui.Utils;

namespace OKEGui.Model
{
    public class AudioInfo : Info
    {
        public string OutputCodec;
        public int Bitrate = Constants.QAACBitrate;
        public bool Lossy = false;

        public AudioInfo() : base()
        {
            InfoType = InfoType.Audio;
        }
    }
}
