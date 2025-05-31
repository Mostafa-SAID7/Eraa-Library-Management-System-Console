---
name: Bug report
about: Create a report to help us improve
title: ''
labels: ''
assignees: ''

---

name: 🛠️ Bug Report
description: Report a bug or unexpected behavior
labels: [bug]
title: '[Bug]: '
body:
  - type: textarea
    id: what-happened
    attributes:
      label: What happened?
      description: Describe the issue you encountered
      placeholder: Something went wrong...
    validations:
      required: true
  - type: input
    id: steps
    attributes:
      label: Steps to reproduce
      placeholder: "1. Run ...\n2. Click ...\n3. See error"
  - type: input
    id: environment
    attributes:
      label: Environment (OS, .NET version, etc.)
      placeholder: "Windows 10, .NET 6.0"
---

**Describe the bug**
A clear and concise description of what the bug is.

**To Reproduce**
Steps to reproduce the behavior:
1. Go to '...'
2. Click on '....'
3. Scroll down to '....'
4. See error

**Expected behavior**
A clear and concise description of what you expected to happen.

**Screenshots**
If applicable, add screenshots to help explain your problem.

**Desktop (please complete the following information):**
 - OS: [e.g. iOS]
 - Browser [e.g. chrome, safari]
 - Version [e.g. 22]

**Smartphone (please complete the following information):**
 - Device: [e.g. iPhone6]
 - OS: [e.g. iOS8.1]
 - Browser [e.g. stock browser, safari]
 - Version [e.g. 22]

**Additional context**
Add any other context about the problem here.
