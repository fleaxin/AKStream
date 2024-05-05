using System;

namespace LibCommon.Structs.ZLMediaKitConfig;

[Serializable]
public class ZLMediaKitConfigNew_Rtp_Proxy
{
    private string? _dumpDir;
    private int? _gop_cache;
    private string? _h264_pt;
    private string? _h265_pt;
    private string? _opus_pt;
    private ushort? _port;
    private string? _port_range;
    private string? _ps_pt;
    private int? _timeoutSec;
    private int? _rtp_g711_dur_ms=100;
    private int? _udp_recv_socket_buffer=4194304;


    /// <summary>
    /// 导出调试数据(包括rtp/ps/h264)至该目录,置空则关闭数据导出
    /// </summary>
    public string DumpDir
    {
        get => _dumpDir;
        set => _dumpDir = value;
    }

    /// <summary>
    /// udp和tcp代理服务器，支持rtp(必须是ts或ps类型)代理端口
    /// </summary>
    public ushort? Port
    {
        get => _port;
        set => _port = value;
    }

    /// <summary>
    /// rtp超时时间，单位秒
    /// </summary>
    public int? TimeoutSec
    {
        get => _timeoutSec;
        set => _timeoutSec = value;
    }

    /// <summary>
    /// 随机端口范围，最少确保36个端口
    /// 该范围同时限制rtsp服务器udp端口范围
    /// </summary>
    public string Port_Range
    {
        get => _port_range;
        set => _port_range = value;
    }

    /// <summary>
    /// rtp h264 负载的pt
    /// </summary>
    public string H264_Pt
    {
        get => _h264_pt;
        set => _h264_pt = value;
    }

    /// <summary>
    /// rtp h265 负载的pt
    /// </summary>
    public string H265_Pt
    {
        get => _h265_pt;
        set => _h265_pt = value;
    }

    /// <summary>
    /// rtp ps 负载的pt
    /// </summary>
    public string Ps_Pt
    {
        get => _ps_pt;
        set => _ps_pt = value;
    }

    /// <summary>
    /// rtp opus 负载的pt
    /// </summary>
    public string Opus_Pt
    {
        get => _opus_pt;
        set => _opus_pt = value;
    }

    /// <summary>
    /// rtp g711a 负载的pt
    /// </summary>
    public int? Gop_Cache
    {
        get => _gop_cache;
        set => _gop_cache = value;
    }

    /// <summary>
    /// #国标发送g711 rtp 打包时，每个包的语音时长是多少，默认是100 ms，范围为20~180ms (gb28181-2016，c.2.4规定)，
    /// #最好为20 的倍数，程序自动向20的倍数取整
    /// </summary>
    public int? Rtp_G711_Dur_Ms
    {
        get => _rtp_g711_dur_ms;
        set => _rtp_g711_dur_ms = value;
    }

    /// <summary>
    /// #udp接收数据socket buffer大小配置
    /// #4*1024*1024=4196304
    /// </summary>
    public int? Udp_Recv_Socket_Buffer
    {
        get => _udp_recv_socket_buffer;
        set => _udp_recv_socket_buffer = value;
    }
}