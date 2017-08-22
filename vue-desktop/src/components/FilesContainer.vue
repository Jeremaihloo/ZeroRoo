<<template>
  <draggable :options="{group:'files'}" class="file-section" v-model="files" @start="drag=true" @end="drag=false">
    <desktop-button v-for="(file, index) in files" :file="file" :key="index" 
      :dragging="drag" 
      :selected="file.selected" 
      @onMouseDown="btnOnMouseDown"
      @onDbClick="btnOnDbClick"></desktop-button>
  </draggable>
</template>

<script>
import Draggable from 'vuedraggable'
import DesktopButton from './DesktopButton'

export default {
  components: {
    Draggable,
    DesktopButton
  },
  methods: {
    test () {
      alert('sdfasfsafasf')
    },
    btnOnMouseDown (file) {
      this.clearSelected()
      file.selected = true
      console.log('OnMouseDown', file)
      this.files.forEach(function (f) {
        console.log(f)
      }, this)
    },
    btnOnDbClick (file) {
      console.log('OnDbClick', file)
      this.$bus.emit('activity:open', file.MenuItem.Activity)
    },
    clearSelected () {
      this.files.forEach(function (file) {
        file.selected = false
      }, this)
    }
  },
  mounted () {
    this.$engine.call({
      ServiceName: 'ZeroRoo.Docker.JsServices.MainAppService',
      Action: 'GetVersion',
      Data: null
    }, res => {
      console.log('ZeroRoo.Docker.JsService.MainAppService', 'GetVersion', res.Data)
    })

    this.$engine.call({
      ServiceName: 'ZeroRoo.Docker.JsServices.DesktopMenuService',
      Action: 'GetDockButtons',
      Data: null
    }, res => {
      console.log('files', res)
      res.Data.forEach(function (f) {
        f.selected = false
      }, this)
      this.files = res.Data
    })
  },
  data () {
    return {
      files: [],
      drag: false
    }
  }
}
</script>

<style scoped>
.file-section {
  background-color: rgb(176, 224, 230);
}
</style>

