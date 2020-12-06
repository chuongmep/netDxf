#region netDxf library, Copyright (C) 2009-2020 Daniel Carvajal (haplokuon@gmail.com)

//                        netDxf library
// Copyright (C) 2009-2020 Daniel Carvajal (haplokuon@gmail.com)
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using netDxf.Entities;
using netDxf.Objects;

namespace netDxf.Collections
{
    /// <summary>
    /// Gives directly access to operations related with the entities in a drawing.
    /// These are no more than shortcuts to the real places where the entities are stored in a document (drawing.Layouts[layoutName].AssociatedBlock.Entities).
    /// The layout where the operations are performed is defined by the ActiveLayout.
    /// </summary>
    public class DrawingEntities
    {
        #region private fields

        private readonly DxfDocument document;
        private string activeLayout;

        #endregion

        #region constructors

        internal DrawingEntities(DxfDocument document)
        {
            this.document = document;
            this.activeLayout = Layout.ModelSpaceName;
        }

        #endregion

        #region public properties

        /// <summary>
        /// Gets or sets the name of the active layout.
        /// </summary>
        public string ActiveLayout
        {
            get { return this.activeLayout; }
            set
            {
                if (!this.document.Layouts.Contains(value))
                {
                    throw new ArgumentException(string.Format("The layout {0} does not exist.", value), nameof(value));
                }
                this.activeLayout = value;
            }
        }

        /// <summary>
        /// Gets the <see cref="Arc">arcs</see> list contained in the active layout.
        /// </summary>
        public IEnumerable<Arc> Arcs
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Arc>(); }
        }

        /// <summary>
        /// Gets the <see cref="AttributeDefinition">attribute definitions</see> list in the active layout.
        /// </summary>
        public IEnumerable<AttributeDefinition> AttributeDefinitions
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.AttributeDefinitions.Values; }
        }

        /// <summary>
        /// Gets the <see cref="Ellipse">ellipses</see> list in the active layout.
        /// </summary>
        public IEnumerable<Ellipse> Ellipses
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Ellipse>(); }
        }

        /// <summary>
        /// Gets the <see cref="Circle">circles</see> list in the active layout.
        /// </summary>
        public IEnumerable<Circle> Circles
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Circle>(); }
        }

        /// <summary>
        /// Gets the <see cref="Face3d">3d faces</see> list in the active layout.
        /// </summary>
        public IEnumerable<Face3d> Faces3d
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Face3d>(); }
        }

        /// <summary>
        /// Gets the <see cref="Solid">solids</see> list in the active layout.
        /// </summary>
        public IEnumerable<Solid> Solids
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Solid>(); }
        }

        /// <summary>
        /// Gets the <see cref="Trace">traces</see> list in the active layout.
        /// </summary>
        public IEnumerable<Trace> Traces
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Trace>(); }
        }

        /// <summary>
        /// Gets the <see cref="Insert">inserts</see> list in the active layout.
        /// </summary>
        public IEnumerable<Insert> Inserts
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Insert>(); }
        }

        /// <summary>
        /// Gets the <see cref="Line">lines</see> list in the active layout.
        /// </summary>
        public IEnumerable<Line> Lines
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Line>(); }
        }

        /// <summary>
        /// Gets the <see cref="Shape">shapes</see> list in the active layout.
        /// </summary>
        public IEnumerable<Shape> Shapes
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Shape>(); }
        }

        /// <summary>
        /// Gets the <see cref="Polyline">polylines</see> list in the active layout.
        /// </summary>
        public IEnumerable<Polyline> Polylines
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Polyline>(); }
        }

        /// <summary>
        /// Gets the <see cref="LwPolyline">light weight polylines</see> list in the active layout.
        /// </summary>
        public IEnumerable<LwPolyline> LwPolylines
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<LwPolyline>(); }
        }

        /// <summary>
        /// Gets the <see cref="PolyfaceMeshes">polyface meshes</see> list in the active layout.
        /// </summary>
        public IEnumerable<PolyfaceMesh> PolyfaceMeshes
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<PolyfaceMesh>(); }
        }

        /// <summary>
        /// Gets the <see cref="Point">points</see> list in the active layout.
        /// </summary>
        public IEnumerable<Point> Points
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Point>(); }
        }

        /// <summary>
        /// Gets the <see cref="Text">texts</see> list in the active layout.
        /// </summary>
        public IEnumerable<Text> Texts
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Text>(); }
        }

        /// <summary>
        /// Gets the <see cref="MText">multiline texts</see> list in the active layout.
        /// </summary>
        public IEnumerable<MText> MTexts
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<MText>(); }
        }

        /// <summary>
        /// Gets the <see cref="Hatch">hatches</see> list in the active layout.
        /// </summary>
        public IEnumerable<Hatch> Hatches
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Hatch>(); }
        }

        /// <summary>
        /// Gets the <see cref="Image">images</see> list in the active layout.
        /// </summary>
        public IEnumerable<Image> Images
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Image>(); }
        }

        /// <summary>
        /// Gets the <see cref="Mesh">mesh</see> list in the active layout.
        /// </summary>
        public IEnumerable<Mesh> Meshes
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Mesh>(); }
        }

        /// <summary>
        /// Gets the <see cref="Leader">leader</see> list in the active layout.
        /// </summary>
        public IEnumerable<Leader> Leaders
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Leader>(); }
        }

        /// <summary>
        /// Gets the <see cref="Tolerance">tolerance</see> list in the active layout.
        /// </summary>
        public IEnumerable<Tolerance> Tolerances
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Tolerance>(); }
        }

        /// <summary>
        /// Gets the <see cref="Underlay">underlay</see> list in the active layout.
        /// </summary>
        public IEnumerable<Underlay> Underlays
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Underlay>(); }
        }

        /// <summary>
        /// Gets the <see cref="MLine">multilines</see> list in the active layout.
        /// </summary>
        public IEnumerable<MLine> MLines
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<MLine>(); }
        }

        /// <summary>
        /// Gets the <see cref="Dimension">dimensions</see> list in the active layout.
        /// </summary>
        public IEnumerable<Dimension> Dimensions
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Dimension>(); }
        }

        /// <summary>
        /// Gets the <see cref="Spline">splines</see> list in the active layout.
        /// </summary>
        public IEnumerable<Spline> Splines
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Spline>(); }
        }

        /// <summary>
        /// Gets the <see cref="Ray">rays</see> list in the active layout.
        /// </summary>
        public IEnumerable<Ray> Rays
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Ray>(); }
        }

        /// <summary>
        /// Gets the <see cref="Viewport">viewports</see> list in the active layout.
        /// </summary>
        public IEnumerable<Viewport> Viewports
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Viewport>(); }
        }

        /// <summary>
        /// Gets the <see cref="XLine">extension lines</see> list in the active layout.
        /// </summary>
        public IEnumerable<XLine> XLines
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<XLine>(); }
        }

        /// <summary>
        /// Gets the <see cref="Wipeout">wipeouts</see> list in the active layout.
        /// </summary>
        public IEnumerable<Wipeout> Wipeouts
        {
            get { return this.document.Layouts[this.activeLayout].AssociatedBlock.Entities.OfType<Wipeout>(); }
        }

        #endregion

        #region public methods

        /// <summary>
        /// Adds a list of <see cref="EntityObject">entities</see> to the document.
        /// </summary>
        /// <param name="entities">A list of <see cref="EntityObject">entities</see> to add to the document.</param>
        public void Add(IEnumerable<EntityObject> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            foreach (EntityObject entity in entities)
            {
                this.Add(entity);
            }
        }

        /// <summary>
        /// Adds an <see cref="EntityObject">entity</see> to the document.
        /// </summary>
        /// <param name="entity">An <see cref="EntityObject">entity</see> to add to the document.</param>
        public void Add(EntityObject entity)
        {
            // entities already owned by another document are not allowed
            if (entity.Owner != null)
            {
                throw new ArgumentException("The entity already belongs to a document. Clone it instead.", nameof(entity));
            }

            this.document.Blocks[this.document.Layouts[this.activeLayout].AssociatedBlock.Name].Entities.Add(entity);
        }

        /// <summary>
        /// Removes a list of <see cref="EntityObject">entities</see> from the document.
        /// </summary>
        /// <param name="entities">A list of <see cref="EntityObject">entities</see> to remove from the document.</param>
        /// <remarks>
        /// This function will not remove other tables objects that might be not in use as result from the elimination of the entity.<br />
        /// This includes empty layers, blocks not referenced anymore, line types, text styles, dimension styles, and application registries.<br />
        /// Entities that are part of a block definition will not be removed.
        /// </remarks>
        public void Remove(IEnumerable<EntityObject> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            foreach (EntityObject entity in entities)
            {
                this.Remove(entity);
            }
        }

        /// <summary>
        /// Removes an <see cref="EntityObject">entity</see> from the document.
        /// </summary>
        /// <param name="entity">The <see cref="EntityObject">entity</see> to remove from the document.</param>
        /// <returns>True if item is successfully removed; otherwise, false. This method also returns false if item was not found.</returns>
        /// <remarks>
        /// This function will not remove other tables objects that might be not in use as result from the elimination of the entity.<br />
        /// This includes empty layers, blocks not referenced anymore, line types, text styles, dimension styles, multiline styles, groups, and application registries.<br />
        /// Entities that are part of a block definition will not be removed.
        /// </remarks>
        public bool Remove(EntityObject entity)
        {
            if (entity == null)
            {
                return false;
            }

            if (entity.Handle == null)
            {
                return false;
            }

            if (entity.Owner == null)
            {
                return false;
            }

            if (entity.Reactors.Count > 0)
            {
                return false;
            }

            if (entity.Owner.Record.Layout == null)
            {
                return false;
            }

            if (!this.document.AddedObjects.ContainsKey(entity.Handle))
            {
                return false;
            }

            return this.document.Blocks[entity.Owner.Name].Entities.Remove(entity);

        }

        #endregion
    }
}
