# 🔒 Security Policy

## 🔒 Our Commitment to Security

The security of the Temperature Converter Console App and its users is a top priority. We take all security vulnerabilities seriously and are committed to addressing them promptly and transparently.

## 📋 Table of Contents

- [Supported Versions](#supported-versions)
- [Reporting Security Vulnerabilities](#reporting-security-vulnerabilities)
- [Security Best Practices](#security-best-practices)
- [Known Security Considerations](#known-security-considerations)
- [Security Update Process](#security-update-process)
- [Disclosure Policy](#disclosure-policy)
- [Security Resources](#security-resources)

## 🔧 Supported Versions

| Version | Supported          | Status              |
| ------- | ------------------ | ------------------- |
| 1.2.x   | ✅ Supported        | Active development  |
| 1.1.x   | ✅ Security Only    | Maintenance mode    |
| 1.0.x   | ❌ Not Supported    | End of Life         |
| < 1.0   | ❌ Not Supported    | Legacy versions     |

### Support Timeline

- **1.2.x**: Full support including features and security updates  
- **1.1.x**: Security updates only for 6 months after 1.2 release  
- **Legacy**: No further updates or support

## 🚨 Reporting Security Vulnerabilities

If you discover a vulnerability, please report it responsibly.

### 📧 How to Report

**DO NOT use GitHub issues for reporting security vulnerabilities.**

### 📞 Contact Information

- **Maintainer**: Mostafa Said  
- [![Email](https://img.shields.io/badge/Email-m.ssaid356%40gmial.com-blue?style=for-the-badge&logo=gmail)](mailto:m.ssaid356@gmial.com)  
- [![GitHub](https://img.shields.io/badge/GitHub-Mostafa--SAID7-black?style=for-the-badge&logo=github)](https://github.com/Mostafa-SAID7)  
- [![Repo](https://img.shields.io/badge/Repo-Temperature--Converter--Console--App-brightgreen?style=for-the-badge&logo=github)](https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App)

### 📝 What to Include

- Description of the issue  
- Steps to reproduce  
- Affected versions  
- Severity and impact  
- Proof of concept (optional but helpful)

## 🛡️ Security Best Practices

### For Users

- Download only from the [official GitHub repo](https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App)  
- Use latest supported version  
- Don’t enter sensitive data  
- Run in a secure environment

### For Developers

- Validate and sanitize input  
- Implement safe exception handling  
- Perform code reviews  
- Use static code analysis tools

## 🔍 Known Security Considerations

### Low-Risk Areas

- Console-only app  
- No networking or data storage  
- Safe math-based logic

### Potential Risks

- Edge case inputs  
- Risk if file I/O is added later

## 🔄 Security Update Process

- Review vulnerability  
- Develop & test fix  
- Perform security review  
- Release with changelog  
- Optional coordinated disclosure

### Severity Levels

| Severity | Response Time | Fix Deadline | Example                                 |
|----------|---------------|--------------|-----------------------------------------|
| Critical | < 24 hrs     | < 7 days     | Remote code execution                   |
| High     | < 48 hrs     | < 14 days    | Privilege escalation                    |
| Medium   | < 7 days     | < 30 days    | Information disclosure                  |
| Low      | < 14 days    | < 90 days    | Minor bugs, non-sensitive issues        |

## 📢 Disclosure Policy

- We follow **responsible disclosure**  
- You will be credited if desired  
- Public disclosure typically after patch release or 90 days max

## 🔗 Security Resources

- [.NET Security Guidelines](https://learn.microsoft.com/en-us/dotnet/standard/security/)  
- [OWASP Cheat Sheets](https://cheatsheetseries.owasp.org/)  
- [CVE Database](https://cve.mitre.org/)

## 🙏 Acknowledgments

Thank you to all security researchers who contribute to a safer open source ecosystem.

---

*Last updated: May 2025*
