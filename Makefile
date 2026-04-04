.PHONY: all, all-debug, build, build-debug, zip-release-nexusmods, zip-release-thunderstore, zip-debug-nexusmods, zip-debug-thunderstore

TARGET_FRAMEWORK := netstandard2.1

MOD_AUTHOR := f4iTh
MOD_NAME := ShowFollowerJobTitles
MOD_VERSION := 1.1.0

# TODO: figure out better way to handle; issue about system path env var
7Z := C:\Program Files\7-Zip\7z.exe

all: build zip-release-nexusmods zip-release-thunderstore
all-debug: build-debug zip-debug-nexusmods zip-debug-thunderstore

build:
	dotnet build -c "Release"

build-debug:
	dotnet build -c "Debug"

zip-release-nexusmods:
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION)_nexusmods.zip" ./bin/Release/$(TARGET_FRAMEWORK)/$(MOD_NAME).dll

zip-release-thunderstore:
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION).zip" ./manifest.json ./icon.png ./docs/README.md ./docs/CHANGELOG.md ./bin/Release/$(TARGET_FRAMEWORK)/$(MOD_NAME).dll

zip-debug-nexusmods:
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION)_nexusmods_debug.zip" ./bin/Debug/$(TARGET_FRAMEWORK)/$(MOD_NAME).dll

zip-debug-thunderstore:
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION)_debug.zip" ./manifest.json ./icon.png ./docs/README.md ./docs/CHANGELOG.md ./bin/Debug/$(TARGET_FRAMEWORK)/$(MOD_NAME).dll
