# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

**Added:**

- External link generation policy.
- Extensibility for developer add customer link policies.
- XML code documentation for `HateoasUriProvider<TPolicy>` and `InMemoryPolicyRepository` classes.

**Changed:**

- README.md code samples for external links configuration and results.
- Exposed policy contract classes to allow policy extensibility.

**Removed:**

- AutoMapper reference from the project.

## [3.0.2] - 2020-05-01

**Fixed:**
	
- Fix for package description format.

## [3.0.0] - 2020-05-01

**Added:**

- Strategy pattern for policies.
- Custom policy for custom link generation.
- .NET Core WebApi application sample.
- XML code documentation for all public classes and members.
- Breaking changes.

**Changed:**

- Migrating to .NET Standard 2.1.
- Improved Custom link generation.
- Azure pipelines badge location.
- Package description.

**Deprecated:**

- Nuget package version 1.0.5
- Nuget package version 1.0.0

**Fixed:**

- Fix per route link generation.
- Fix per custom link generation.
- Fix in path generation.

## [1.0.5] - 2019-03-07

**Fixed:**

- Route link generation issue.

## [1.0.0] - 2019-03-07

**Added:**

- Self link generation.
- Route link generation.
- Customer link generation.
- Full documentation and code samples.