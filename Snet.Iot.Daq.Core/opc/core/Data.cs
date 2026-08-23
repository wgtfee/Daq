using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Snet.Iot.Daq.Core.opc.core
{

    /// <summary>
    /// OPC 公共基础数据类，定义 OPC 客户端/服务端共用的认证类型枚举和证书路径常量。
    /// </summary>
    public class Data
    {
        /// <summary>
        /// 认证类型
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum AuType
        {
            /// <summary>
            /// 匿名
            /// </summary>
            [Description("匿名")]
            Anonymous,
            /// <summary>
            /// 用户名
            /// </summary>
            [Description("用户名")]
            UserName,
            /// <summary>
            /// 证书
            /// </summary>
            [Description("证书")]
            Certificate,
        }

        /// <summary>
        /// 证书路径（只读，基于应用基目录拼接 cer 子目录）
        /// </summary>
        public static readonly string AppCerPath = Path.Combine(AppContext.BaseDirectory, "cer", "app");
    }
}
