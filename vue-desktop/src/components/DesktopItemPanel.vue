<<template>
  <draggable :options="{group:'items'}" class="item-section" v-model="items" @start="drag=true" @end="drag=false">
    <desktop-button v-for="(item, index) in items" :item="item" :key="index" 
      :dragging="drag" 
      :selected="item.selected" 
      @onMouseDown="btnOnMouseDown"></desktop-button>
  </draggable>
</template>

<script>
import Draggable from 'vuedraggable'
import DesktopButton from './DesktopItem'

export default {
  components: {
    Draggable,
    DesktopButton
  },
  methods: {
    btnOnMouseDown (item) {
      this.clearSelected()
      item.selected = true
      // console.log('OnMouseDown', item)
      this.items.forEach(function (f) {
        // console.log(f)
      }, this)
    },
    clearSelected () {
      this.items.forEach(function (item) {
        item.selected = false
      }, this)
    }
  },
  mounted () {
    // this.$engine.call({
    //   Service: 'ZeroRoo.Docker.Cores.Services.GetVersion',
    //   Data: null
    // }, res => {
    //   console.log('ZeroRoo.Docker.Cores.Services.GetVersion', 'GetVersion', res.Data)
    // })

    this.$engine.call({
      Service: 'ZeroRoo.DefaultApp.Services.GetAppMenuItems',
      Data: null
    }, res => {
      if (res.Ok) {
        res.Data.forEach(function (f) {
          f.selected = false
        }, this)
        this.items = Object.assign([], res.Data)
      } else {
        console.log('[ERROR]', res.Data)
      }
    })
  },
  data () {
    return {
      items: [],
      drag: false
    }
  }
}
</script>

<style scoped>
.item-section {
  background-color: rgb(176, 224, 230);
}
</style>

