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

using LicenseManager.Api.Dto.Enum;

namespace LicenseManager.Api.Dto;

/// <summary>
/// User of organization data transfer object
/// </summary>
public class UserOrganizationDto
{
    public Guid Id { get; set; }
    public OrganizationRole Role { get; set; }
    public UserDto User { get; set; }
    public DateTimeOffset CreatedUtc { get; set; }
}