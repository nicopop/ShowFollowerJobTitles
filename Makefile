.PHONY: all, clean, release, debug, build-release, build-debug, zip-release, zip-debug

TARGET_FRAMEWORK := netstandard2.1

MOD_AUTHOR := f4iTh
MOD_NAME := ShowFollowerJobTitles
MOD_VERSION := 1.1.1

# TODO: figure out better way to handle; issue about system path env var
7Z := C:\Program Files\7-Zip\7z.exe

all: release debug

release: clean build-release zip-release
debug: clean build-debug zip-debug

clean:
	if exist build\ rd /S /Q build

build-release:
	dotnet build -c "Release"

	if not exist build\ md build
	md build\Release
	md build\Release\plugins

	xcopy ".\manifest.json" ".\build\Release\manifest.json" /Y /-I
	xcopy ".\icon.png" ".\build\Release\icon.png" /Y /-I
	xcopy ".\docs\README.md" ".\build\Release\README.md" /Y /-I
	xcopy ".\docs\CHANGELOG.md" ".\build\\Release\CHANGELOG.md" /Y /-I
	xcopy ".\bin\Release\$(TARGET_FRAMEWORK)\$(MOD_NAME).dll" ".\build\Release\plugins\$(MOD_NAME).dll" /Y /-I

zip-release:
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION)_nexusmods.zip" ./build/Release/plugins/$(MOD_NAME).dll
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION).zip" ./build/Release/*

build-debug:
	dotnet build -c "Debug"

	if not exist build\ md build
	md build\Debug
	md build\Debug\plugins

	xcopy ".\manifest.json" ".\build\Debug\manifest.json" /Y /-I
	xcopy ".\icon.png" ".\build\Debug\icon.png" /Y /-I
	xcopy ".\docs\README.md" ".\build\Debug\README.md" /Y /-I
	xcopy ".\docs\CHANGELOG.md" ".\build\Debug\CHANGELOG.md" /Y /-I
	xcopy ".\bin\Debug\$(TARGET_FRAMEWORK)\$(MOD_NAME).dll" ".\build\Debug\plugins\$(MOD_NAME).dll" /Y /-I

zip-debug:
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION)_nexusmods_debug.zip" ./build/Debug/plugins/$(MOD_NAME).dll
	$(7Z) a -bd -aoa -tzip "releases/$(MOD_AUTHOR)-$(MOD_NAME)-$(MOD_VERSION)_debug.zip" ./build/Debug/*
