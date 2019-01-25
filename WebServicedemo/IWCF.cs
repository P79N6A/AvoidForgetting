using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServicedemo
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IWCF”。
    [ServiceContract]
    public interface IWCF
    {
        [OperationContract]
        string DoWork();

        [OperationContract]
        int Plus(int x, int y);
    }
}
