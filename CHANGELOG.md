# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).


## [1.0.0] - 2022-01-01

### Added

- State, StateMachine got added

## [2.0.0] - 2024-11-18

### Added
- StateParameters can now be used to add large number of states in a single call

### Changed

- StateTransition has been moved to the Specialised namespace and commented out for now
- TransitionalStateMachine has been moved to the Specialised namespace and commented out for now
- State now uses Update over OnTick
- State now uses Exit over OnExit
- State now uses Enter over OnEnter

### Removed

- Tests have been removed due to large changes in the system
- Removed IState interface

## [2.1.0] - 2024-11-19

### Changed

- Updated dependency of bbunity-test-support to 2.1.0