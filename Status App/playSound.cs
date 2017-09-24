using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Status_App
{
    public class playSound
    {
        private string PlayCommand;
        private bool isOpen;

        //lấy file hệ thống
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr oCallback);

        public void ClosePlayer()
        {
            PlayCommand = "Close MediaFile";
            mciSendString(PlayCommand, null, 0, IntPtr.Zero);
            isOpen = false;
        }
        //hàm mở file
        public void OpenMediaFile(string strFileName)
        {
            PlayCommand = "Open \"" + strFileName + "\" alias MediaFile";
            mciSendString(PlayCommand, null, 0, IntPtr.Zero);
            isOpen = true;
        }
        // hàm này dùng để cho phép lặp hại hay không
        public void PlayMediaFile(bool loop)
        {
            if (isOpen)
            {
                PlayCommand = "Play MediaFile";
                if (loop)
                    PlayCommand += " REPEAT";
                mciSendString(PlayCommand, null, 0, IntPtr.Zero);
            }
        }
    }
}