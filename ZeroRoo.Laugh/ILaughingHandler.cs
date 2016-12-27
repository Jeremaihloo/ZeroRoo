using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroRoo.Laughing
{
    public interface ILaughingHandler
    {
        /// <summary>
        /// this method will be called before any processing
        /// </summary>
        /// <param name="manager">manager doing the execution</param>
        void BeforeProcess(LaughingManager manager);

        /// <summary>
        /// this method will be called after all processing is done
        /// </summary>
        /// <param name="manager">manager doing the execution</param>
        void AfterProcess(LaughingManager manager);
    }
}
