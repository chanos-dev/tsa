﻿namespace tsa.Config
{
    public class CertificateConfig
    {
        public string RootCAPath { get; set; } = string.Empty;
        public string RootKeyPath { get; set; } = string.Empty;
        public string RootPassword { get; set; } = string.Empty;
        public string GeneralPassword { get; set; } = string.Empty;
    }
}
