#ifndef FIND_H
#define FIND_H

#include <vector>
#include "Company.h"

Company *find(std::vector<Company *> v, int id);

Company *find(std::vector<Company *> v, int id)
{
	Company *found = nullptr;
	Company *it = v[0];
	const int size = v.size();

	for (int i = 0; i < size; ++i)
	{
		if (it->getId() == id)
		{
			found = it;
			break;
		}
		else
		{
			it++;
		}
	}

	return found;
}

#endif // !FIND_H
