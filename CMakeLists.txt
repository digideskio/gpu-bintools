#
# Copyright (c) 2011 Justin Holewinski
#
# Permission is hereby granted, free of charge, to any person obtaining a copy
# of this software and associated documentation files (the "Software"), to deal
# in the Software without restriction, including without limitation the rights
# to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
# copies of the Software, and to permit persons to whom the Software is
# furnished to do so, subject to the following conditions:
#
# The above copyright notice and this permission notice shall be included in
# all copies or substantial portions of the Software.
#
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
# IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
# AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
# LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
# OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
# THE SOFTWARE.
#


cmake_minimum_required(VERSION 2.8)

project(gpu-tools)


# Locate Boost
find_package(Boost REQUIRED)

# Sometimes, the FindBoost script does not honor the "required" flag.
# So we forcea bail-out here.
if(NOT Boost_FOUND)
  message(FATAL_ERROR "Unable to locate Boost.")
endif()

include_directories(${Boost_INCLUDE_DIRS})


set(_header_root  "${CMAKE_CURRENT_SOURCE_DIR}/include/gpubintools")
include_directories("${CMAKE_CURRENT_SOURCE_DIR}/include")


add_subdirectory(libs)


# Add header install target
install(DIRECTORY include/gpubintools DESTINATION include)
