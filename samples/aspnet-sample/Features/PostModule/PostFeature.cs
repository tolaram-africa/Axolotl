// Copyright 2022 - 2023 Godwin peter .O (me@godwin.dev)
// 
// Licensed under the MIT License;
// you may not use this file except in compliance with the License.
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Proton.Common.AspNet.Feature;

namespace Proton.Common.AspNetSample.Features.PostModule;

public class PostFeature : GenericFeature, IFeature {
    public override IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints) {
        var group = SetupGroup<Post>(endpoints);

        return group;
    }
}