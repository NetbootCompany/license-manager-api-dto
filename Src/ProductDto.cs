// This file is part of LicenceManager. Copyright © 2022 Netboot.
//
// LicenceManager is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3
// of the License, or any later version.
//
// LicenceManager is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with LicenceManager. If not, see <http://www.gnu.org/licenses/>.

namespace LicenseManager.Api.Dto;

/// <summary>
/// Product data transfer object
/// </summary>
public class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Company { get; set; }
    public OrganizationDto Organization { get; set; }
}