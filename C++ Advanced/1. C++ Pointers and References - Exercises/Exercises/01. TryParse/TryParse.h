#pragma once
#include<sstream>
bool tryParse(std::string& s, int& a)
{
	std::istringstream istr(s);
	if (istr >> a)
	{
		return true;
	}
	return false;
}