string[] maliciousUrls =
[
    "http://malicious.example/credential-harvest",
    "https://phishing-login.example/verify-account",
    "http://198.51.100.42/dropper.exe",
    "https://evil.example/payload?type=ransomware",
    "http://suspicious.example/free-gift-card",
    "https://nav.smartscreen.msft.net/phishingdemo.html"
];

Console.WriteLine("Sample malicious URLs for scanner testing:");
foreach (string url in maliciousUrls)
{
    Console.WriteLine(url);
}
