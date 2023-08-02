﻿namespace SyncClipboard.Core.Models.Configs;

public record class SyncConfig
{
    public string RemoteURL { get; set; } = "";
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";
    public bool SyncSwitchOn { get; set; } = false;
    public bool PullSwitchOn { get; set; } = true;
    public bool PushSwitchOn { get; set; } = true;
    public bool UseLocalServer { get; set; } = true;
    public bool DeletePreviousFilesOnPush { get; set; } = true;
    public int MaxFileByte { get; set; } = 1024 * 1024 * 20;  // 20MB 
    public int IntervalTime { get; set; } = 3;
    public int RetryTimes { get; set; } = 3;
    public uint TimeOut { get; set; } = 100;
}
